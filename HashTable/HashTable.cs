using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataStructureAndAlgorithms.HashTable
{
    class HashTable
    {
        private object[] data;
        public HashTable(int size)
        {
            data = new object[size];
        }

        private int _generateHash(string key)
        {
            int hash = 0;
            for(int i=0;i<key.Length;i++)
            {
                hash = (hash+ key[i] *i) % i;
            }
            return hash;
        }
    }
}
