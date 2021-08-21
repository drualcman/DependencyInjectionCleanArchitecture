using DependencyInyectionMediatR.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyInjectionMediatR.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class MessageUserControl : UserControl
    {

        private readonly IMediator Mediator;
        public MessageUserControl(IMediator mediator)
        {
            InitializeComponent();
            Mediator = mediator;

            buttonSend.Click += (s, e) => textMesssage.Text = Mediator.Send(new Ping()).Result;
        }
    }
}
