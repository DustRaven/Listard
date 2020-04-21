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

        private int _used
        {
            get
            {
                int internalCount = 0;
                for (int count = 0; count < Count; count++)
                {
                    if (persons[count] != null)
                    {
                        internalCount += 1;
                    }
                }

                return internalCount;
            }
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
            Array.Copy(tempPersons, persons, tempPersons.Length);
        }

        public void Add(Person p)
        {
            if (_used >= listSize)
            {
                ResizeList();
            }

            persons[_used] = p;
        }


        public bool Contains(Person person)
        {
            return IndexOf(person) >= 0;
        }

        public Person Get(int index)
        {
            return persons[index];
        }

        public int GetCount()
        {
            return Count;
        }

        public Person GetFirst()
        {
            return persons[0];
        }

        public Person GetLast()
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

        public int IndexOf(Person p)
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

        public void InsertAt(int index, Person p)
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

        public bool Remove(Person p)
        {
            int countBefore = IndexOf(GetLast()) + 1;
            for (int index = IndexOf(p); index < IndexOf(GetLast()); index++)
            {
                persons[index] = persons[index++];
            }

            persons[IndexOf(GetLast())] = null;
            return (countBefore - 1) == IndexOf(GetLast());
        }

        public void Replace(Person oldPerson, Person newPerson)
        {
            persons[IndexOf(oldPerson)] = newPerson;
        }

        public void ReplaceAt(int index, Person p)
        {
            persons[index] = p;
        }

        /**
         * @todo Implement Sort(bool byFirstname, bool ascending)
         * @body Sorting the list. By firstname if the first parameter is "true" (defaults to "false"), ascending if the
         * second parameter is "true" (defaults to "true").
         */
        public void Sort(bool byFirstname = false, bool ascending = true)
        {
            if (byFirstname)
            {
                if (ascending)
                {
                    Array.Sort(persons,
                        (person1, person2) =>
                            String.Compare(person1.FirstName, person2.FirstName, StringComparison.InvariantCulture));                    
                }
                else
                {
                    Array.Sort(persons,
                        (person1, person2) =>
                            String.Compare(person2.FirstName, person1.FirstName, StringComparison.InvariantCulture));
                }
            }
            else
            {
                if (ascending)
                {
                    Array.Sort(persons,
                        (person1, person2) =>
                            String.Compare(person1.LastName, person2.LastName, StringComparison.InvariantCulture));   
                }
                else
                {
                    Array.Sort(persons,
                        (person1, person2) =>
                            String.Compare(person2.LastName, person1.LastName, StringComparison.InvariantCulture));
                }
            }
        }
    }
}