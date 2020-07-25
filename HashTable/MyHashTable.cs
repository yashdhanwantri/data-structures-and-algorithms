using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataStructureAndAlgorithms.HashTable
{
    class MyHashTable
    {
        private object[] data;
        public MyHashTable(int size)
        {
            data = new object[size];
        }

        private int _generateHash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + key[i] * i) % data.Length;
            }
            return hash;
        }

        public object set(string key, int value)
        {
            int address = _generateHash(key);
            if (data[address] == null)
            {
                data[address] = new { key, value };
                return "Successfully inserted";
            }
            else
                return $"Key {key} already exist.";
                
        }
        public object get(string key)
        {
            int address = _generateHash(key);
            if(data[address]!=null)
            {
                return data[address];
            }
            return $"Key {key} does not exist";
        }
    }
}
