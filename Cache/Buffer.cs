using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheUtility.Cache
{
    public class Buffer
    {

        public byte[] buffer;
        public int currentOffset;
        public int bitPosition;

        public void writeWord(int i)
        {
            buffer[currentOffset++] = (byte)(i >> 8);
            buffer[currentOffset++] = (byte)i;
        }

		public void readBytes(int i, int j, byte[] abyte0)
		{
			for (int l = j; l < j + i; l++)
				abyte0[l] = buffer[currentOffset++];
		}

	}
}
