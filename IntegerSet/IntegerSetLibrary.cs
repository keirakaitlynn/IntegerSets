﻿using System;
using System.Text;

namespace IntegerSetLibrary
{
    public class IntegerSet
    {
        private const int SET_SIZE = 101;
        private bool[] mSet;

        // Parameterless Constructor
        public IntegerSet()
        {
            mSet = new bool[SET_SIZE];
        }
        // Parameterized Constructor
        public IntegerSet(int[] array) : this()
        { // "this()" : calls its parameterless constructor too
            for (int i = 0; i < array.Length; i++)
            {
                InsertElement(array[i]);
            }
        }

        // InsertElement()
        public void InsertElement(int integerToInsert)
        {
            //  if "integerToInsert" isValid && NOT in "mSet"
            if (ValidEntry(integerToInsert))
            {
                // add "integerToInsert" to "mSet"
                mSet[integerToInsert] = true;
            }
        }

        private bool ValidEntry(int integerValue)
        {
            // Check if the given integer value is in the range 0-100.
            return integerValue >= 0 && integerValue < SET_SIZE;
        }

        // TODO: DeleteElement()
        public void DeleteElement(int integerToDelete) { }

        // Union()
        public IntegerSet Union(IntegerSet otherSet)
        {
            IntegerSet unionSet = new IntegerSet();
            for (int i = 0; i < SET_SIZE; i++)
            {
                // If this mSet[i] is true or otherSet.mSet[i] is true,
                // then make the unionSet.mSet[i] to be true as well.
                unionSet.mSet[i] = (mSet[i] || otherSet.mSet[i]);
            }
            return unionSet;
        }

        // Intersection()
        public IntegerSet Intersection(IntegerSet integerSet)
        {
            IntegerSet intersection = new IntegerSet();

            for (int i = 0; i < SET_SIZE; i++)
            {
                // if this mSet[i] == integerSet's mSet[i] then they intersect @ i.
                intersection.mSet[i] = (mSet[i] && integerSet.mSet[i]);
            }
            return intersection;
        }

        // TODO: IsEqualTo()
        public bool IsEqualTo(IntegerSet integerSet)
        {
            bool isEqualTo = false;
            return isEqualTo;
        }

        // ToString()
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append("{");

            for (int i = 0; i < SET_SIZE; i++)
            {
                if (mSet[i])
                {
                    toString.Append(" " + i);
                }
            }

            toString.Append(" }");
            return toString.ToString();
        }
    }
}
