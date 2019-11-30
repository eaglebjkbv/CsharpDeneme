using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YilanOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 10;
        PictureBox[] pbox = new PictureBox[100];
        int[] pleft=new int[100];
        int[] ptop = new int[100];
        
        private void Form1_Load(object sender, EventArgs e)
        {
            int basX = 120;
            int basY = 150;
            
            for (int i = 0; i < sayi; i++)
            {
                pbox[i] = new PictureBox();
                pbox[i].Size=new System.Drawing.Size(20, 20);
                pbox[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pbox[i].Left = i * 20+ basX;
                pleft[i] = pbox[i].Left;
                ptop[i]=pbox[i].Top;
                pbox[i].Top = basY;

                pbox[i].BackColor = Color.Red;

                this.Controls.Add(pbox[i]);
            }
            yonler[0] = 0;
            yonler[1] = 0;
            yonler[2] = 0;
            yonler[3] = 0;


        }

        // sol=0 yukarı=1 sag=2 aşağı=3;
        int yon=0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up && yonler[0]!=3)   yon = 1;
            if (e.KeyData == Keys.Left && yonler[0]!=2) yon = 0;
            if (e.KeyData == Keys.Down && yonler[0] != 1) yon = 3;
            if (e.KeyData == Keys.Right && yonler[0] != 0) yon = 2;

        }

        int[] yonler = new int[100];
        
        void kaydir(){

            int[] yedek=new int[100];
            for(int i=0;i<sayi;i++){
                if(i<sayi-1) yedek[i+1]=yonler[i];    
            }
            yonler=yedek;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kaydir();
            yonler[0]=yon;
            for(int i=0;i<sayi;i++){
                if(yonler[i]==0){
                       pbox[i].Left-=20;
                } 
                if(yonler[i]==1){
                       pbox[i].Top-=20;
                } 
                if(yonler[i]==2){
                       pbox[i].Left+=20;
                } 
                if(yonler[i]==3){
                       pbox[i].Top+=20;
                } 
            
            }
                     
            }

        }   
    }

