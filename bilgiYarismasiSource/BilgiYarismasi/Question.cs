using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi
{
    class Question
    {
        private string questionNo;
        private string question;
        private string choiceA;
        private string choiceB;
        private string choiceC;
        private string choiceD;
        private string trueAnswer;
        private string time;
        private string questionLevel;
        private string topicNo;

        public Question()
        {
            questionNo = "";
            question = "";
            choiceA = "";
            choiceB = "";
            choiceC = "";
            choiceD = "";
            trueAnswer = "";
            time = "";
            questionLevel = "";
            topicNo = "";
        }

        public void setAllValues(string questionNo, string question,
                                 string choiceA, string choiceB, string choiceC, string choiceD,
                                 string trueAnswer, string time, string questionLevel, string topicNo)
        {
            this.questionNo = questionNo;
            this.question = question;
            this.choiceA = choiceA;
            this.choiceB = choiceB;
            this.choiceC = choiceC;
            this.choiceD = choiceD;
            this.trueAnswer = trueAnswer;
            this.time = time;
            this.questionLevel = questionLevel;
            this.topicNo = topicNo;
        }

        public string getQuestion() { return question; }
        public string getChoiceA() { return choiceA; }
        public string getChoiceB() { return choiceB; }
        public string getChoiceC() { return choiceC; }
        public string getChoiceD() { return choiceD; }
        public string getTrueAnswer() { return trueAnswer; }
        public string getTime() { return time; }



    }
}

