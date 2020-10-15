﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coletar_itens.Classes;

namespace Coletar_itens
{
    public partial class Coleta : Form
    {
        Movimento mov = new Movimento();
        Colisao colisao = new Colisao();
        nextLevel level = new nextLevel();
        Score pontos = new Score();
        Image rigth = Properties.Resources.rigth;
        Image left = Properties.Resources.left;
        Image up = Properties.Resources.up;
        Image down = Properties.Resources.down;
        Image apodrecendo = Properties.Resources.apodrecendo;
        Image podre = Properties.Resources.maca_podre;
        int speed = 15;
        bool estragando = false;
        int tempo = 20;
       

        public Coleta()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.W))
            {
                mov.Up(Player, speed);
                Player.Image = up;
            }

            if((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.S))
            {
                mov.Down(Player, speed);
                Player.Image = down;
            }

            if((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.D))
            {
                mov.Rigth(Player, speed);
                Player.Image = rigth;
            }

            if((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.A))
            {
                mov.Left(Player, speed);
                Player.Image = left;
            }

           if(pictureBox1.Image != podre && pictureBox2.Image != podre && pictureBox3.Image != podre
                &&
                pictureBox4.Image != podre && pictureBox5.Image != podre && pictureBox6.Image != podre
                &&
                pictureBox7.Image != podre && pictureBox8.Image != podre && pictureBox9.Image != podre
                &&
                pictureBox10.Image != podre && pictureBox11.Image != podre)
            { 
                colisao.Coll(Player, pictureBox1);
                colisao.Coll(Player, pictureBox2);
                colisao.Coll(Player, pictureBox3);
                colisao.Coll(Player, pictureBox4);
                colisao.Coll(Player, pictureBox5);
                colisao.Coll(Player, pictureBox6);
                colisao.Coll(Player, pictureBox7);
                colisao.Coll(Player, pictureBox8);
                colisao.Coll(Player, pictureBox9);
                colisao.Coll(Player, pictureBox10);
                colisao.Coll(Player, pictureBox11);

                lb_score.Text = $"Score: {colisao.x.ToString()}";
            }
            else
            {
                gameOver over = new gameOver(Player, game_over);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = apodrecendo;
            pictureBox2.Image = apodrecendo;
            pictureBox3.Image = apodrecendo;
            pictureBox4.Image = apodrecendo;
            pictureBox5.Image = apodrecendo;
            pictureBox6.Image = apodrecendo;
            pictureBox7.Image = apodrecendo;
            pictureBox8.Image = apodrecendo;
            pictureBox9.Image = apodrecendo;
            pictureBox10.Image = apodrecendo;
            pictureBox11.Image = apodrecendo;

            

            timer2.Enabled = true;
            timer1.Enabled = false;
        }
        
        private void score_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true; //COMENTEI O TIMER 1 PARA FAZER UM TESTE
            estragando = true;
            lb_tempo.Text = $"Tempo: {tempo.ToString()}";
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = podre;
            pictureBox2.Image = podre;
            pictureBox3.Image = podre;
            pictureBox4.Image = podre;
            pictureBox5.Image = podre;
            pictureBox6.Image = podre;
            pictureBox7.Image = podre;
            pictureBox8.Image = podre;
            pictureBox9.Image = podre;
            pictureBox10.Image = podre;
            pictureBox11.Image = podre;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            level.tempo--;
            lb_tempo.Text = $"Tempo: {level.tempo.ToString()}";
            if(level.tempo <= 0)
            {
                timer3.Enabled = false;
                gameOver over = new gameOver(Player, game_over);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            level.ChegarGanhos(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, lb_tempo, lb_level);
        }
    }
}
