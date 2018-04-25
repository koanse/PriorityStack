using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityStack
{
	public partial class MainForm : Form
	{
		StackNoPr stackNoPr = new StackNoPr();
		StackPr stackPr = new StackPr();

		public MainForm()
		{
			InitializeComponent();

			tbStackNoPr.Text = stackNoPr.ToString();
			tbStackPr.Text = stackPr.ToString();
		}
		

		private void btnClearNoPriority_Click(object sender, EventArgs e)
		{
			stackNoPr.Clear();
			tbStackNoPr.Text = stackNoPr.ToString();
		}

		private void btnAddNoPr_Click(object sender, EventArgs e)
		{
			try
			{
				var value = int.Parse(tbElementNoPr.Text);
				stackNoPr.Push(value);
				tbStackNoPr.Text = stackNoPr.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnResultNoPr_Click(object sender, EventArgs e)
		{
			try
			{
				var value = stackNoPr.Pop();
				tbStackNoPr.Text = stackNoPr.ToString();
				tbResultNoPr.Text = value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new AboutForm("О программе", "Модель обработки массива типа “стек”" + Environment.NewLine + "Версия 1");
			form.ShowDialog();
		}

		private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var form = new AboutForm("Справка", "Программа работает со стеком целых чисел."
				+ Environment.NewLine + "Для работы со стеком без приоритетов перейдите на вкладку “Без приоритетов” и очистите стек, добавьте или извлеките элементы, просмотрите содержимое."
				+ Environment.NewLine + "Для работы со стеком с приоритетами перейдите на вкладку “С приоритетами” и очистите стек, добавьте или извлеките элементы с учетом приоритетов, просмотрите содержимое.");
			form.ShowDialog();
		}

		private void btnClearPr_Click(object sender, EventArgs e)
		{
			stackPr.Clear();
			tbStackPr.Text = stackPr.ToString();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				var value = int.Parse(tbElementPr.Text);
				var priority = int.Parse(tbPriority.Text);
				stackPr.Push(value, priority);
				tbStackPr.Text = stackPr.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnResultPr_Click(object sender, EventArgs e)
		{
			try
			{
				var value = stackPr.Pop();
				tbStackPr.Text = stackPr.ToString();
				tbResultPr.Text = value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
