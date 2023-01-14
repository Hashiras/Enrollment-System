﻿using System.Collections;
using System;

namespace Enrollment_System.Data
{
    class SubjectManager
    {
        private SubjectManager()
        {
            subjects = new ArrayList();
        }
        private static SubjectManager instance = null;
        public ArrayList subjects { get; set; }

        public static SubjectManager getInstance()
        {
            if (instance == null)
                instance = new SubjectManager();
            return instance;
        }

        public void add(Subject subject)
        {
            subjects.Add(subject);
        }

        public void update(Subject x)
        {
            subjects[subjects.IndexOf(x)] = x;
        }

        public int retrieveRecentID()
        {
            if (subjects.Count == 0)
                return -1;
            Subject x = (Subject)subjects[subjects.Count - 1];
            return x.ID;
        }

        public void removeRecent()
        {
            if (subjects.Count == 0)
                return;
            subjects.RemoveAt(subjects.Count - 1);
        }

        public Subject find(int Id)
        {
            for (int i = 0; i < subjects.Count; i++)
            {
                Subject s = (Subject)subjects[i];
                if (s.ID == Id)
                    return s;
            }
            return null;
        }

        public Subject findByIndex(int index)
        {
            return (Subject)subjects[index];
        }

        public Subject findByName(string Name)
        {
            for (int i = 0; i < subjects.Count; i++)
            {
                Subject s = (Subject)subjects[i];
                if (s.Name.Equals(Name))
                    return s;
            }
            return null;
        }

        public int findIndex(Subject x)
        {
            return subjects.IndexOf(x);
        }

        public void clear()
        {
            subjects.Clear();
        }
    }
}
