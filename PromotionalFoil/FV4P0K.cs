using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace PromotionalFoil
{
    // ReSharper disable InconsistentNaming
    public partial class FV4P0K : Form
    // ReSharper restore InconsistentNaming
    {
        public int DisplayType;
        private TableLayoutPanel _tableLayoutPanel;
        private Panel _panelK;
        private Panel _panelTlp;
        private Panel _panel2;
        private Panel _panel3;
        private Panel _panel4;
        private Panel _panel5;

        private Video _videoTopLeft;
        private Video _videoTopRight;
        private Video _videoBottomLeft;
        private Video _videoBottomRight;
        private string _kyronText;

        private ScrollingText _scrollingText;

        public FV4P0K()
        {
            DisplayType = 1;
            InitializeComponent();
        }

        private void FV4P0K_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            var cv = new ClassVideo(@"c:/ss", 120, ClassGlobal.Position.Full);
            init_layout(DisplayType);
        }

        private void init_layout(int iDisplayType)
        {
            _tableLayoutPanel = new TableLayoutPanel();
            Controls.Clear();
            switch (iDisplayType)
            {
                case 1:
                    _panelK = new Panel { Dock = DockStyle.Bottom, Size = new Size(0, 60) };
                    _scrollingText = new ScrollingText
                        {
                            Dock = DockStyle.Fill,
                            ScrollText =
                                "test scroll texta test scroll texta test scroll texta test scroll texta test scroll texta",
                            ForeColor = Color.Red,
                            BackColor = Color.LightSteelBlue,
                            Font = new Font(FontFamily.GenericSerif, 30)
                        };
                    _panelK.Controls.Add(_scrollingText);                  

                    _panelTlp = new Panel { Dock = DockStyle.Fill };

                    _tableLayoutPanel.Dock = DockStyle.Fill;
                    _tableLayoutPanel.RowCount = 2;
                    _tableLayoutPanel.ColumnCount = 2;
                    _tableLayoutPanel.BackColor = Color.Transparent;
                    _tableLayoutPanel.Visible = true;
                    _tableLayoutPanel.BorderStyle=BorderStyle.FixedSingle;

                    _panel2 = new Panel { Dock = DockStyle.Fill, Visible = true, BackColor = Color.Transparent };
                    _tableLayoutPanel.Controls.Add(_panel2, 0, 0);

                    _panel3 = new Panel { Dock = DockStyle.Fill, Visible = true, BackColor = Color.Transparent };
                    _tableLayoutPanel.Controls.Add(_panel3, 1, 0);

                    _panel4 = new Panel { Dock = DockStyle.Fill, Visible = true, BackColor = Color.Transparent };
                    _tableLayoutPanel.Controls.Add(_panel4, 0, 1);

                    _panel5 = new Panel { Dock = DockStyle.Fill, Visible = true, BackColor = Color.Transparent };
                    _tableLayoutPanel.Controls.Add(_panel5, 1, 1);

                    _tableLayoutPanel.ColumnStyles.Clear();
                    _tableLayoutPanel.RowStyles.Clear();

                    for (var i = 1; i <= 2; i++)
                    {
                        var cs = new ColumnStyle(SizeType.Percent, 2);
                        _tableLayoutPanel.ColumnStyles.Add(cs);
                        var rs = new RowStyle(SizeType.Percent, 2);
                        _tableLayoutPanel.RowStyles.Add(rs);
                    }

                    _tableLayoutPanel.CellBorderStyle=TableLayoutPanelCellBorderStyle.InsetDouble;

                    _panelTlp.Controls.Add(_tableLayoutPanel);
                    Controls.Add(_panelTlp);
                    Controls.Add(_panelK);
                    _panelTlp.Visible = true;
                    _panelK.Visible = true;
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }

        }
    }
}
