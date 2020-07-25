using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataStructureAndAlgorithms.HashTable
{
    class MyHashTable
    {
        private List<Item>[] data;
        public MyHashTable(int size)
        {
            data = new List<Item>[size];
        }

        internal class Item
        {
            internal string key;
            internal int value;
        }
        private int _generateHash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % data.Length;
            }
            return hash;
        }

        public List<Item> Set(string key, int value)
        {
            int address = _generateHash(key);
            if (data[address] == null)
            {
                data[address] = new List<Item> { new Item { key = key, value = value } };
                return data[address];
            }
            data[address].Add(new Item{ key = key, value = value });
            return data[address];
        }
        public int Get(string key)
        {
            int address = _generateHash(key);
            if (data[address] != null)
            {
                for (int i = 0; i < data[address].Count; i++)
                {
                    if (data[address][i].key == key)
                        return data[address][i].value;
                }
            }
                return 99999999;
        }

        public void Print()
        {
            foreach (var item in data)
            {
                Console.Write("[ ");
                foreach (var obj in item)
                {
                    Console.Write($"{{ Key: {obj.key}, Value: {obj.value} }}, ");
                }
                Console.WriteLine(" ]");
            }
        }
    }
}
