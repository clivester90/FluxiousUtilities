using System;

namespace CacheUtility.Cache
{
    public class CacheConstants
    {

        public string RecentCacheDirectory { get; set; }


        public string GetFileSize(long length)
        {
            long B, KB = 1024, MB = KB * 1024, GB = MB * 1024;

            double size = length;
            string suffix = nameof(B);

            if (length >= GB)
            {
                size = Math.Round(size / GB, 2);
                suffix = nameof(GB);
            }
            else if (length >= MB)
            {
                size = Math.Round(size / MB, 2);
                suffix = nameof(MB);
            }
            else if (length >= KB)
            {
                size = Math.Round(size / KB, 2);
                suffix = nameof(KB);
            }

            return $"{size} {suffix}";
        }

    }
}
