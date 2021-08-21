using DependencyInyectionMediatR.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjectionMediatR.Presentation.WindowfForm
{
    public partial class Message : Form
    {

        private readonly IMediator Mediator;
        public Message(IMediator mediator)
        {
            InitializeComponent();
            Mediator = mediator;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtMessage.Text = Mediator.Send(new Ping()).Result;
        }
    }
}
