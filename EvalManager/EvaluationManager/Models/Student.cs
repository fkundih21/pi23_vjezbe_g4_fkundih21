using EvaluationManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EvaluationManager.Models
{
    public class Student : Person
    {
        public int Grade { get; set; }

        public list<Evaluation> GetEvaluations()
        {
            return EvaluationRepository.GetEvaluation(this);
    }
        public int CalculateTotalPoints()
        {
            int totalPoints = 0;
            foreach (var evaluation in GetEvaluation()){
                totalPoints += evaluation.Points;
            } return totalPoints;
        }

        private bool IsEvalutionComplete()
        {
            var evalutions = GetEvaluations();
            var activities = ActivityRepository.GetActivities();
            return evalutions.count == activities.count;
        }

        public bool HasGrade()
        {
            bool hasGrade = true;
            if (IsEvalutionComplete() == true) {
                foreach (var evalution in GetEvaluations())
                {
                    if (evalution.IsSufficientForSignature() == false)
                    {
                        hasGrade = false;
                        break;
                    }
                }
            }else
            {
                hasGrade=false;
            } return hasGrade;
        }

        public int CalculateGrade()
        {
            int grade = 0;
            if (HasGrade() == true)
            {
                int totalPoints=CalculateTotalPoints
                    if(totalPoints >= 91)
                {
                    grade = 5;
                }else if(totalPoints >= 76)
                {
                    grade = 4;
                }
                else if (totalPoints >= 61)
                {
                    grade = 3;
                }
                else if (totalPoints >= 50)
                {
                    grade = 2;
                }
                else 
                {
                    grade = 1;
                }
            } return grade;
    }
}
