using LearnDesignPatterns.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnDesignPatterns
{
    public partial class frmMemento : Form
    {
        private Originator _originator;
        private CareTaker _careTaker;
        private int _saveFiles;
        private int _currentArticle;


        public frmMemento()
        {
            InitializeComponent();

            _originator=new Originator();
            _careTaker=new CareTaker();
            _currentArticle = 0;
            _saveFiles = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _originator.Set(txtDescription.Text);
            _careTaker.Add(_originator.StoreInmemento());
            _saveFiles++;
            _currentArticle++;
            btnUndo.Enabled = true;

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (_currentArticle >= 1)
            {
                _currentArticle--;
                txtDescription.Text = _originator.RestoreFrom(_careTaker.Get(_currentArticle));
                btnRedo.Enabled = true;
            }
            else
            {
                btnUndo.Enabled = false;
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if ((_saveFiles - 1) > _currentArticle)
            {
                _currentArticle++;
                txtDescription.Text = _originator.RestoreFrom(_careTaker.Get(_currentArticle));
                btnUndo.Enabled = true;
            }
            else
            {
                btnRedo.Enabled = false;
            }

        }
    }
}
