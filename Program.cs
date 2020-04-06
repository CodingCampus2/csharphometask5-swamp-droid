using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task5, Task5.Virus> TaskSolver = task =>
            {
                Task5.Virus virus = new SuperVirus();
                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }

    class SuperVirus : Task5.Virus
    {
        float m_KillProbability;
        string m_Name;
        string m_VictimName;
        bool m_Alive;
        DateTime m_DateTimeOfCreation;

        public SuperVirus() : this(false) 
        { 
        }

        public SuperVirus(bool alive) : base(alive)
        {
            m_Alive = alive;
            m_DateTimeOfCreation = DateTime.Now;
        }

        public override float KillProbability 
        { 
            get
            {
                return m_KillProbability;
            }
            set
            {
                m_KillProbability = Math.Clamp(value * 2f, 0f, 1f);
            }
        }

        public override string Name 
        { 
            get
            {
                return m_Name;
            }
            set
            {
                int pos = value.IndexOf("virus");
                m_Name = value.Insert(pos, "super");
            }
        }

        public override string VictimName 
        { 
            get { return m_VictimName; }
            set { m_VictimName = value; }
        }

        public override DateTime DateTimeOfCreation
        {
            get { return m_DateTimeOfCreation; }
        }

        public new bool Alive 
        { 
            get { return m_Alive; }
        }
    }
}
