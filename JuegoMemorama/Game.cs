using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace JuegoMemorama {
    public partial class Game : Form {

        private int rowSize = 4;
        private int moves = 0;
        private int flipCards = 0;
        private List<string> numberedCards;
        private List<string> scrambledCards;
        private ArrayList selectedCards;
        private PictureBox temporaryCard1;  
        private PictureBox temporaryCard2;
        private int currentCard = 0;
        private Stopwatch stopWatch = new Stopwatch();
        private static bool isPlay = false;
        private static string currentTime;
        private string namePlayer;

        public Game() {
            InitializeComponent();
            startGame();
        }

        public void startGame() {

            timeChange.Enabled = false;
            timeChange.Stop();
            lblRecord.Text = "0";
            lblResult.Text = "";
            btnReset.Cursor = Cursors.Hand;
            flipCards = 0;
            moves = 0;
            GamePanel.Controls.Clear();
            numberedCards = new List<string>();
            scrambledCards = new List<string>();
            selectedCards = new ArrayList();
            for (int i = 1; i <= 8; i++) {
                numberedCards.Add(i.ToString());
                numberedCards.Add((i*10).ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = numberedCards.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado) {
                scrambledCards.Add(ValorCarta);
            }
            var panelTable = new TableLayoutPanel();
            panelTable.RowCount = rowSize;
            panelTable.ColumnCount = rowSize;
            for (int i = 0; i < rowSize; i++) {
                var Porcentaje = 150f / (float)rowSize - 10;
                panelTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                panelTable.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;

            for (var i = 0; i < rowSize; i++) {
                for (var j = 0; j < rowSize; j++) {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Girada;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    panelTable.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            panelTable.Dock = DockStyle.Fill;
            GamePanel.Controls.Add(panelTable);
        } 

        private void btnReiniciar_Click(object sender, EventArgs e) {
            startGame();
            resetTimeGame();
        }

        private void btnCarta_Click(object sender, EventArgs e) {

            if (!isPlay) {
                startTimeGame();
                isPlay = true;
            } 

            if (selectedCards.Count < 2) {
                moves++;
                lblRecord.Text = Convert.ToString(moves);
                var selectedCardUser = (PictureBox)sender;

                currentCard = Convert.ToInt32(scrambledCards[Convert.ToInt32(selectedCardUser.Name) - 1]);
                selectedCardUser.Image = getImage(currentCard);
                selectedCards.Add(selectedCardUser);

                if (selectedCards.Count == 2) {
                    temporaryCard1 = (PictureBox)selectedCards[0];
                    temporaryCard2 = (PictureBox)selectedCards[1];
                    int Carta1 = Convert.ToInt32(scrambledCards[Convert.ToInt32(temporaryCard1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(scrambledCards[Convert.ToInt32(temporaryCard2.Name) - 1]);

                    if (Carta2 == (Carta1 * 10) || Carta2 == (Carta1 / 10)) {
                        flipCards++;
                        if (flipCards > 7) {
                            lblResult.Text = "Congratulations!";
                            stopWatch.Stop();
                        }
                        temporaryCard1.Enabled = false; 
                        temporaryCard2.Enabled = false;
                        selectedCards.Clear();
                    } else {
                        timeChange.Enabled = true;
                        timeChange.Start();
                    }
                }
            }
        }

        public Bitmap getImage(int NumeroImagen) => (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + NumeroImagen);

        private void timeChange_Tick(object sender, EventArgs e) {
            int TiempoGirarCarta = 1;
            if (TiempoGirarCarta == 1) {
                temporaryCard1.Image = Properties.Resources.Girada;
                temporaryCard2.Image = Properties.Resources.Girada;
                selectedCards.Clear();
                TiempoGirarCarta = 0;
                timeChange.Stop();
            }
        }

        public void startTimeGame() {
            stopWatch.Start();
            timeGame.Enabled = true;
        }

        public void resetTimeGame() {

            stopWatch.Stop();
            stopWatch.Reset();
            timeGame.Enabled = false;
            lblTimer.Text = "";
            isPlay = false;
        }

        private void timeGame_Tick(object sender, EventArgs e) {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopWatch.ElapsedMilliseconds);

            string min = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            string seg = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();

            currentTime = min + ":" + seg;
            lblTimer.Text = min + ":" + seg;
        }
    }
}