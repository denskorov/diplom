﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Testing_3.CompareString;
using Testing_3.Model;

namespace Testing_3
{
    class QuestionNotify : INotifyPropertyChanged
    {
        int trueQuestion = 0;
        public int TrueQuestion
        {
            set
            {
                trueQuestion = value;
                NotifyPropertyChanged();
            }
            get
            {
                return trueQuestion;
            }
        }

        int numberQuestion = 0;
        public int NumberQuestion
        {
            set
            {
                numberQuestion = value;
                NotifyPropertyChanged();
            }
            get
            {
                return numberQuestion;
            }
        }

        int index = 0;

        Question[] questions;

        Question curentQuestion;

        public Question CurentQuestion
        {
            set
            {
                if (!EquivalentQuestion.Contains(value))
                {
                    curentQuestion = value;
                    EquivalentQuestion.AddRange(CurentQuestion.EquivalentQuestion);
                    NotifyPropertyChanged();
                }
                else
                {
                    SkipQuestion();
                }
            }
            get
            {
                return curentQuestion;
            }
        }

        List<Question> EquivalentQuestion;

        public QuestionNotify(Question[] questions)
        {
            EquivalentQuestion = new List<Question>();
            this.questions = questions;
            CurentQuestion = questions[index];
            NumberQuestion++;
            index++;
        }

        public bool NextQuestion(string textAnswer)
        {
            if (CurentQuestion.Answers.Count > 0)
            {
                var i = ScoreSharp.score(CurentQuestion.Answers[0].Text, textAnswer);
            }

            if (index++ < questions.Count())
            {
                CurentQuestion = questions[index++];
                NumberQuestion++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NextQuestion(Answer answer)
        {
            foreach (var ans in CurentQuestion.Answers)
            {
                if (ans.Corect && ans.Id == answer.Id)
                {
                    TrueQuestion++;
                }
            }

            if (NumberQuestion < questions.Count() - 1)
            {
                CurentQuestion = questions[index++];
                NumberQuestion++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NextQuestion(Answer[] answers)
        {
            var i = CurentQuestion.Answers.Where(a => a.Corect).Count();
            var j = answers.Where(a => a.Corect == true).Count();

            if (i != 0 && j != 0 && i == j)
            {
                TrueQuestion++;
            }

            if (NumberQuestion < questions.Count() - 1)
            {
                CurentQuestion = questions[index++];
                NumberQuestion++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SkipQuestion()
        {
            CurentQuestion = questions[index++];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
