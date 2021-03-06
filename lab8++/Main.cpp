#include <Windows.h>
// one can also use Winternl.h if needed
//#include <Winternl.h> // for UNICODE_STRING and SYSTEM_INFORMATION_CLASS
#include <stdio.h>
#include <tchar.h>

#define STATUS_SUCCESS               ((NTSTATUS)0x00000000L)
#define STATUS_INFO_LENGTH_MISMATCH  ((NTSTATUS)0xC0000004L)

typedef enum _SYSTEM_INFORMATION_CLASS {
	SystemProcessInformation = 5
} SYSTEM_INFORMATION_CLASS;

typedef struct _UNICODE_STRING {
	USHORT Length;
	USHORT MaximumLength;
	PWSTR  Buffer;
} UNICODE_STRING;

typedef LONG KPRIORITY; // Thread priority

typedef struct _SYSTEM_PROCESS_INFORMATION_DETAILD {
	ULONG NextEntryOffset;
	ULONG NumberOfThreads;
	LARGE_INTEGER SpareLi1;
	LARGE_INTEGER SpareLi2;
	LARGE_INTEGER SpareLi3;
	LARGE_INTEGER CreateTime;
	LARGE_INTEGER UserTime;
	LARGE_INTEGER KernelTime;
	UNICODE_STRING ImageName;
	KPRIORITY BasePriority;
	HANDLE UniqueProcessId;
	ULONG InheritedFromUniqueProcessId;
	ULONG HandleCount;
	BYTE Reserved4[4];
	PVOID Reserved5[11];
	SIZE_T PeakPagefileUsage; //The maximum amount of virtual memory, in bytes, that this process has reserved for use in the paging files.
	SIZE_T PrivatePageCount;
	LARGE_INTEGER Reserved6[6];
} SYSTEM_PROCESS_INFORMATION_DETAILD, *PSYSTEM_PROCESS_INFORMATION_DETAILD;

typedef NTSTATUS (WINAPI *PFN_NT_QUERY_SYSTEM_INFORMATION)(
	IN       SYSTEM_INFORMATION_CLASS SystemInformationClass,
	IN OUT   PVOID SystemInformation,
	IN       ULONG SystemInformationLength,
	OUT OPTIONAL  PULONG ReturnLength
	);

int main()
{
	size_t bufferSize = 102400;
	PSYSTEM_PROCESS_INFORMATION_DETAILD pspid=
		static_cast<PSYSTEM_PROCESS_INFORMATION_DETAILD>(malloc (bufferSize));
	ULONG ReturnLength;
	PFN_NT_QUERY_SYSTEM_INFORMATION pfnNtQuerySystemInformation = PFN_NT_QUERY_SYSTEM_INFORMATION(GetProcAddress (GetModuleHandle(TEXT("ntdll.dll")), "NtQuerySystemInformation"));
	NTSTATUS status;

	while (TRUE) {
		status = pfnNtQuerySystemInformation (SystemProcessInformation, PVOID(pspid),
			bufferSize, &ReturnLength);
		if (status == STATUS_SUCCESS)
			break;
		if (status != STATUS_INFO_LENGTH_MISMATCH) { // 0xC0000004L
			_tprintf (TEXT("ERROR 0x%X\n"), status);
			return 1;   // error
		}

		bufferSize *= 2;
		pspid = static_cast<PSYSTEM_PROCESS_INFORMATION_DETAILD>(realloc (static_cast<PVOID>(pspid), bufferSize));
	}

	for (;;
		pspid=reinterpret_cast<PSYSTEM_PROCESS_INFORMATION_DETAILD>(pspid->NextEntryOffset + PBYTE(pspid))) {

			_tprintf (L"ProcessId= %d, fileName= %ls, priority= %u, threadsCount= %u\n, PeakPagefileUsage= %d, InheritedFromUniqueProcessId= %d\n----\n", reinterpret_cast<int>(pspid->UniqueProcessId),
				pspid->ImageName.Length && pspid->ImageName.Buffer? pspid->ImageName.Buffer: L"", pspid->BasePriority, pspid->NumberOfThreads, pspid->PeakPagefileUsage, pspid->InheritedFromUniqueProcessId);

			if (pspid->NextEntryOffset == 0) break;
	}


	system("Pause");
	return 0;
}