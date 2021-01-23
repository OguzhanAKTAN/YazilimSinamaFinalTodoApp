using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaFinal
{
    public partial class ScrumBoard : Form
    {
        Board board;
        public ScrumBoard()
        {
            InitializeComponent();
        }
        private void ClearAllCreatedButtons()
        {
            foreach (Button item in panel_todo.Controls)
            {
                item.Dispose();
            }
            foreach (Button item in panel_inprogress.Controls)
            {
                item.Dispose();
            }
            foreach (Button item in panel_revision.Controls)
            {
                item.Dispose();
            }
            foreach (Button item in panel_check.Controls)
            {
                item.Dispose();
            }
            foreach (Button item in panel_done.Controls)
            {
                item.Dispose();
            }
        }
        private void AddCardButtonToPanel(Button button,string durum)
        {
            switch (durum)
            {
                case "panel_todo":
                    button.Size = new Size(353, 57);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.White;
                    button.Visible = true;
                    button.Parent = panel_todo;
                    button.BringToFront();
                    button.Dock = DockStyle.Top;
                    button.MouseMove += Card_MouseMove;
                    button.MouseClick += Card_MouseClick;
                    button.ContextMenuStrip = CardContextMenu;
                    break;
                case "panel_inprogress":
                    button.Size = new Size(353, 57);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.White;
                    button.Visible = true;
                    button.Parent = panel_inprogress;
                    button.BringToFront();
                    button.Dock = DockStyle.Top;
                    button.MouseMove += Card_MouseMove;
                    button.MouseClick += Card_MouseClick;
                    button.ContextMenuStrip = CardContextMenu;
                    break;
                case "panel_revision":
                    button.Size = new Size(353, 57);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.White;
                    button.Visible = true;
                    button.Parent = panel_revision;
                    button.BringToFront();
                    button.Dock = DockStyle.Top;
                    button.MouseMove += Card_MouseMove;
                    button.MouseClick += Card_MouseClick;
                    button.ContextMenuStrip = CardContextMenu;
                    break;
                case "panel_check":
                    button.Size = new Size(353, 57);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.White;
                    button.Visible = true;
                    button.Parent = panel_check;
                    button.BringToFront();
                    button.Dock = DockStyle.Top;
                    button.MouseMove += Card_MouseMove;
                    button.MouseClick += Card_MouseClick;
                    button.ContextMenuStrip = CardContextMenu;
                    break;
                case "panel_done":
                    button.Size = new Size(353, 57);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.White;
                    button.Visible = true;
                    button.Parent = panel_done;
                    button.BringToFront();
                    button.Dock = DockStyle.Top;
                    button.MouseMove += Card_MouseMove;
                    button.MouseClick += Card_MouseClick;
                    button.ContextMenuStrip = CardContextMenu;
                    break;
                default:
                    break;
            }
        }
        private void FillPanelsWithCards(Board brd)
        {
            ClearAllCreatedButtons();
            brd.cards.Clear();
            brd.SetCards();
            foreach (ScrumCard card in brd.cards)
            {
                card.button = new Button();
                card.button.Name = card.cardid.ToString();
                card.button.Text = card.cardname;
                AddCardButtonToPanel(card.button, card.panelname);
            }
        }
        public ScrumBoard(Board board)
        {
            InitializeComponent();
            this.board = board;           
            
        }

        private void ScrumBoard_Load(object sender, EventArgs e)
        {
            FillPanelsWithCards(board);
            foreach (Personel personel in board.project.personels)
            {
                pERSONELToolStripMenuItem.DropDownItems.Add(personel.personelname);
            }
        }

        #region EventHandlers
        private void movetoToDo_Click(object sender, EventArgs e)
        {
            Button button = CardContextMenu.SourceControl as Button;
            button.Parent = panel_todo;
            DataBaseQueries.UpdateCardPanel(Convert.ToInt32(button.Name), "panel_todo");
        }

        private void movetoInProgress_Click(object sender, EventArgs e)
        {
            Button button = CardContextMenu.SourceControl as Button;
            button.Parent = panel_inprogress;
            DataBaseQueries.UpdateCardPanel(Convert.ToInt32(button.Name), "panel_inprogress");
        }

        private void movetoRevision_Click(object sender, EventArgs e)
        {
            Button button = CardContextMenu.SourceControl as Button;
            button.Parent = panel_revision;
            DataBaseQueries.UpdateCardPanel(Convert.ToInt32(button.Name), "panel_revision");
        }

        private void movetoCheck_Click(object sender, EventArgs e)
        {
            Button button = CardContextMenu.SourceControl as Button;
            button.Parent = panel_check;
            DataBaseQueries.UpdateCardPanel(Convert.ToInt32(button.Name), "panel_check");
        }

        private void movetoDone_Click(object sender, EventArgs e)
        {
            Button button = CardContextMenu.SourceControl as Button;
            button.Parent = panel_done;
            DataBaseQueries.UpdateCardPanel(Convert.ToInt32(button.Name), "panel_done");
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button button = sender as Button;
                button.DoDragDrop(button, DragDropEffects.Move);
            }
        }
        private void Card_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            TeknikKartForm teknik = new TeknikKartForm(Convert.ToInt32(button.Name),board.project.personels);
            if (teknik.ShowDialog()==DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void button_addpersonel_Click(object sender, EventArgs e)
        {
            TeknikKartForm teknik = new TeknikKartForm(board.project);
            if (teknik.ShowDialog()==DialogResult.Cancel)
            {
                ClearAllCreatedButtons();
                FillPanelsWithCards(board);
            }
        }
        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            Panel parent = sender as Panel;
            e.Effect = DragDropEffects.Move;
            parent.BackColor = Color.FromArgb(14, 113, 114);
        }
        private void panel_DragLeave(object sender, EventArgs e)
        {
            Panel parent = sender as Panel;
            parent.BackColor = Color.FromArgb(0, 32, 41);
        }
        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Panel parent = sender as Panel;
            Button button = (Button)e.Data.GetData(typeof(Button));
            button.Parent = parent;
            parent.BackColor = Color.FromArgb(0, 32, 41);
            DataBaseQueries.UpdateCardPanel(Convert.ToInt32(button.Name), parent.Name);
        }
        #endregion
    }
}
