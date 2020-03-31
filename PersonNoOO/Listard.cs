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
            get { return persons[index]; }
            set { persons[index] = value; }
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
        
        
        bool Contains(Person person)
        {
            return IndexOf(person) >= 0;
        }
        
        Person Get(int index)
        {
            return persons[index];
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
            int countBefore = IndexOf(GetLast()) + 1;
            for (int index = IndexOf(p); index < IndexOf(GetLast()); index++)
            {
                persons[index] = persons[index++];
            }

            persons[IndexOf(GetLast())] = null;
            return (countBefore - 1) == IndexOf(GetLast());
        }
        
        void Replace(Person oldPerson, Person newPerson)
        {
            persons[IndexOf(oldPerson)] = newPerson;
        }

        void ReplaceAt(int index, Person p)
        {
            persons[index] = p;
        }

        /**
         * @todo Implement Sort(bool byFirstname, bool ascending)
         * @body Sorting the list. By firstname if the first parameter is "true" (defaults to "false"), ascending if the
         * second parameter is "true" (defaults to "true").
         */
        void Sort(bool byFirstname = false, bool ascending = true)
        {
            throw new NotImplementedException();
        }
    }
}