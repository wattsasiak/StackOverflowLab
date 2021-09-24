using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;


namespace StackOverflowV1.Models
{
    public class DAL
    {
        //my database connection
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=stackoverflow;Uid=root;Password=@OurBe3utifulNew1Home");

        //Get all Questions

        public static List<Questions> GetAllQuestions()
        {
            return DB.GetAll<Questions>().ToList();
        }


        //EDIT A QUESTION
        public static void EditQuestion(Questions QtoEdit)
        {
            DB.Update(QtoEdit);
        }
        

        //DELETE A QUESTION

        public static void CloseQuestion(int ID)
        {
            Questions QuestionToDelete = new Questions() { ID = ID };
            DB.Delete(QuestionToDelete);
        }

        //ADD A QUESTION
        public static void AddAQuestion (Questions AddNewQuestion)
        {
            DB.Update(AddNewQuestion);
        }



        public static IEnumerable<Answers> GetAnswers(int QuestionID)
        {
            var keyvalues = new { QuestionID = QuestionID };
            string sql = "select * from Answers where QuestionID = @QuestionID";


            IEnumerable<Answers> answers = DB.Query<Answers>(sql, keyvalues);

            return answers;



        }

    }
}
