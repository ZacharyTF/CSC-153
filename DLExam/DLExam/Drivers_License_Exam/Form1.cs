using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/**
 * 02-05-2021
 * CSC 153
 * Zachary Fegan
 * Program that takes answers for a 20 question test and compares them to the actual answers to determine if the student passed. Then Displays the amount of questions answered correctly, incorrectly, and a list of numbers
 * for the questions that were answered incorrectly
 */

namespace Drivers_License_Exam
{
    public partial class Form1 : Form
    {
        readonly char[] CORRECT_ANSWERS = new char[20] { 'B', 'D', 'A', 'A', 'C',
                                                         'A', 'B', 'A', 'C', 'D',
                                                         'B', 'C', 'D', 'A', 'D',
                                                         'C', 'C', 'B', 'D', 'A' };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            listBox1.Items.Clear();

            char[] studentAnswers = GetStudentAnswers();

            GradeTest(studentAnswers);
        }

        public char[] GetStudentAnswers()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    char[] studentAnswers = new char[20];
                    StreamReader inputFile = File.OpenText(openFileDialog1.FileName);


                    int index = 0;
                    while (index < studentAnswers.Length && !inputFile.EndOfStream)
                    {
                        studentAnswers[index] = char.Parse(inputFile.ReadLine());
                        index++;
                    }

                    inputFile.Close();
                    return studentAnswers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Operation cancelled.");
                return null;
            }
        }

        public void GradeTest(char[] studentAnswers)
        {
            int score = 0;
            string Result;

            for (int index = 0; index < CORRECT_ANSWERS.Length; index++)
            {
                if (CORRECT_ANSWERS[index] == studentAnswers[index])
                {
                    score++;
                }
                else
                {
                    listBox1.Items.Add($"{index + 1}. \t{studentAnswers[index]} \t(Correct = {CORRECT_ANSWERS[index]})");
                }
            }

            if (score >= 15)
            {
                Result = "You passed the exam.";
            }
            else
            {
                Result = "You failed the exam.";
            }

            lblDisplay.Text = $"{score} correctly answered \n{20 - score} incorrectly answered \n"+ Result;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
