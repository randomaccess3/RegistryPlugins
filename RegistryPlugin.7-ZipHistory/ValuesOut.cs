using System;
using RegistryPluginBase.Interfaces;

namespace RegistryPlugin._7_ZipHistory
{
    public class ValuesOut:IValueOut
    {
        public ValuesOut(int index, string archiveName, DateTimeOffset? lastWriteTime)
        {
            Index = index;
            ArchiveName = archiveName;
            LastWriteTime = lastWriteTime?.UtcDateTime;
        }

        public int Index { get; }
        public string ArchiveName { get; }
        public DateTime? LastWriteTime { get; }
        public string BatchKeyPath { get; set; }
        public string BatchValueName { get; set; }
        public string BatchValueData1 => $"Archive: {ArchiveName}";
        public string BatchValueData2 =>
            $"Last write: {LastWriteTime?.ToString("yyyy-MM-dd HH:mm:ss.fffffff") ?? "N/A"}";
        public string BatchValueData3 => $"Index: {Index}";
    }
}