﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatas_2._0
{
    public partial class Form1 : Form
    {
        string[] alfabeto;
        public int num_estados;
        List<string> Q;
        List<Transition> Delta;
        List<string> F;
        public string QO = "q0";
        


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            var num = 0;
            
            int.TryParse(numEstados.Text, out num);
            if (num > 0)
            {
                Q = new List<string>();
                checkedFinal.Items.Clear();


                for (int i = 0; i < num; i++)
                {
                    Q.Add("q" + i);

                }

                estadoInicial.Text = Q[0];
                //dropInicial.Items.AddRange(Q.ToArray());
                checkedFinal.Items.AddRange(Q.ToArray());
                alfabeto = alfabetoTb.Text.Split(',');
                colOrigen.DataSource = Q;
                colDestino.DataSource = Q;
                colAlfabeto.DataSource = alfabeto;

            }
        }

        public class Transition
        {
            public string StartState { get; private set; }
            public string Token { get; private set; }
            public string EndState { get; private set; }

            public Transition(string startState, string token, string endState)
            {
                StartState = startState;
                Token = token;
                EndState = endState;
            }

            public override string ToString()
            {
                return string.Format("({0},{1} -> {2})", StartState, Token, EndState);
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Transition> list = new List<Transition>();
            
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                //I've assumed imaginary properties ColName and ColValue in MyItem class
                list.Add(new Transition(Convert.ToString(dr.Cells[0].Value),
                    Convert.ToString(dr.Cells[1].Value.ToString()), Convert.ToString(dr.Cells[2].Value)));

            }



        }
    }
}
