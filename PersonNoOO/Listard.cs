using System;

namespace PersonNoOO
{
    // TODO: Test!
    public class Listard
    {
        private static int listSize = 0;
        private Person[] persons = new Person[listSize];

        public int Count
        {
            get { return persons.Length; }
        }

        /**
         * @todo Implement this[int index]
         * @body Dunno what this should do...
         */
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

        /**
         * @todo Implement Contains()
         * @body Something is missing here, like a parameter...
         */
        bool Contains()
        {
            throw new NotImplementedException();
        }

        /**
         * @todo Implement Get(int index)
         * @body This should return a Person object at the given index.
         */
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

        /**
         * @todo Implement Remove(Person p)
         * @body This should remove a person from the list, identified by a Person object and return true if the operation
         * was successful, otherwise false.
         */
        bool Remove(Person p)
        {
            throw new NotImplementedException();
        }

        /**
         * @todo Implement Replace(Person oldPerson, Person newPerson)
         * @body Obviously, this should replace a given person with another.
         */
        void Replace(Person oldPerson, Person newPerson)
        {
            throw new NotImplementedException();
        }

        /**
         * @todo Implement ReplaceAt(int index, Person p)
         * @body This should replace a person at a given index.
         */
        void ReplaceAt(int index, Person p)
        {
            throw new NotImplementedException();
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