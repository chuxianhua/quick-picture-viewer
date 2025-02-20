﻿using QuickLibrary;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class NavPanel : UserControl
	{
		public int borderSpacing = 27;

		private Point navPanelRelPoint;
		public int extraTopMargin;
		public int extraBottomMargin;
		private MainForm owner;

		public NavPanel(int extraTopMargin, int extraBottomMargin)
		{
			this.extraTopMargin = extraTopMargin;
			this.extraBottomMargin = extraBottomMargin;

			TabStop = false;

			InitializeComponent();
		}

		public void SetExtraTopMargin(int top)
		{
			if (Top == borderSpacing + extraTopMargin)
			{
				Top = borderSpacing + top;
			}
			extraTopMargin = top;
		}

		public void SetExtraBottomMargin(int bottom)
		{
			if (Top == Parent.ClientRectangle.Height - borderSpacing - extraBottomMargin - Height)
			{
				Top = Parent.ClientRectangle.Height - borderSpacing - bottom - Height;
			}
			extraBottomMargin = bottom;
		}

		public void SetSlideshowChecked(bool b)
		{
			if (b)
			{
				navSlideshowBtn.BackColor = ThemeMan.DarkPaleColor;
				navSlideshowBtn.FlatAppearance.MouseOverBackColor = ThemeMan.DarkPaleColor;
				navSlideshowBtn.FlatAppearance.BorderSize = 1;
			}
			else
			{
				navSlideshowBtn.BackColor = ThemeMan.DarkMainColor;
				navSlideshowBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
				navSlideshowBtn.FlatAppearance.BorderSize = 0;
			}
		}

		private void NavPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				navPanelRelPoint = new Point(e.X, e.Y);
			}
		}

		private void NavPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point newLoc = new Point(e.X + Location.X - navPanelRelPoint.X, e.Y + Location.Y - navPanelRelPoint.Y);
				if (newLoc.X < borderSpacing)
				{
					newLoc.X = borderSpacing;
				}
				if (newLoc.Y < borderSpacing + extraTopMargin)
				{
					newLoc.Y = borderSpacing + extraTopMargin;
				}
				if (newLoc.X + Width > Parent.ClientRectangle.Width - borderSpacing)
				{
					newLoc.X = Parent.ClientRectangle.Width - borderSpacing - Width;
				}
				if (newLoc.Y + Height > Parent.ClientRectangle.Height - borderSpacing - extraBottomMargin)
				{
					newLoc.Y = Parent.ClientRectangle.Height - borderSpacing - Height - extraBottomMargin;
				}
				Location = newLoc;
			}
		}

		private void NavPanel_Load(object sender, System.EventArgs e)
		{
			owner = Parent as MainForm;

			infoTooltip.SetToolTip(navPrevBtn, LangMan.Get("prev-image") + " | " + LangMan.Get("left-arrow"));
			infoTooltip.SetToolTip(navNextBtn, LangMan.Get("next-image") + " | " + LangMan.Get("right-arrow"));
			infoTooltip.SetToolTip(navSlideshowBtn, LangMan.Get("slideshow") + " | Ctrl+Shift+S");

			Location = new Point(borderSpacing, Parent.ClientRectangle.Height - extraBottomMargin - Height - borderSpacing);
		}

		private void navNextBtn_Click(object sender, System.EventArgs e)
		{
			owner.nextFile();
		}

		private void navSlideshowBtn_Click(object sender, System.EventArgs e)
		{
			owner.toggleSlideshow();
		}

		private void navPrevBtn_Click(object sender, System.EventArgs e)
		{
			owner.prevFile();
		}
	}
}
