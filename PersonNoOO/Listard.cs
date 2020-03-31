using System;

namespace PersonNoOO
{
    public class Listard
    {
        private static int listSize = 0;
        private Person[] persons = new Person[listSize];

        public int Count
        {
            get { return persons.Length; }
        }

        public Person this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        private void ResizeList()
        {
            Person[] tempPersons = persons;
            listSize = listSize == 0 ? listSize = 1 : listSize *= 2;
            persons = new Person[listSize];
            persons = tempPersons;
        }

        public void Add(Person p)
        {
            if (Count + 1 >= listSize)
            {
                ResizeList();
            }
            persons[Count+1] = p;
        }

        bool Contains()
        {
            throw new NotImplementedException();
        }

        Person Get(int index)
        {
            throw new NotImplementedException();
        }

        int GetCount()
        {
            return Count;
        }

        Person GetFirst()
        {
            return persons[0];
        }

        Person GetLast()
        {
            for (int index = 0; index < persons.Length; index++)
            {
                if (persons[index] == null)
                {
                    return persons[index - 1];
                }
            }

            return null;
        }

        int IndexOf(Person p)
        {
            for (int index = 0; index < persons.Length; index++)
            {
                if (persons[index] == p)
                {
                    return index;
                }
            }

            return -1;
        }

        void InsertAt(int index, Person p)
        {
            Person lastPerson = GetLast();
            int lastIndex = IndexOf(lastPerson);
            
            Add(lastPerson);
            for (int tempIndex = lastIndex; tempIndex > index; tempIndex--)
            {
                persons[tempIndex] = persons[tempIndex - 1];
            }

            persons[index] = p;
        }

        bool Remove(Person p)
        {
            throw new NotImplementedException();
        }

        void Replace(Person oldPerson, Person newPerson)
        {
            throw new NotImplementedException();
        }

        void ReplaceAt(int index, Person p)
        {
            throw new NotImplementedException();
        }

        void Sort(bool byFirstname = false, bool ascending = true)
        {
            throw new NotImplementedException();
        }
    }
}