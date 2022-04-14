using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RabbitMQ.Client;
namespace RabbitMQ.Producer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool _isConnectionOpen;
        private bool isConnectionOpen
        {
            get => _isConnectionOpen;

            set
            {
                _isConnectionOpen = value;
                ConnectionStateChanged();
            }
        }

        private IModel _channel;
        private IModel channel => _channel ?? (_channel = CreateOrGetChannel());
        private IConnection connection;

        private IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }
        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnection.Text, uriKind: UriKind.RelativeOrAbsolute)
            };
            return factory.CreateConnection();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!_isConnectionOpen || connection == null)
            {
                connection = GetConnection();
            }
            else
            {
                connection.Close();
            }
            isConnectionOpen = connection.IsOpen;
        }

        private void ConnectionStateChanged()
        {
            btnConnect.Text = isConnectionOpen ? "Disconnect" : "Connect";

            UpdateConnectionStatus();

        }

        private void UpdateConnectionStatus()
        { 

            groupBox2.Enabled = groupBox3.Enabled = groupBox4.Enabled = groupBox5.Enabled = isConnectionOpen;
        }
   

        private void btnDeclareExchange_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(txtDeclareExchangeName.Text, cmbDeclareExchangeType.Text); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Direct : Yapılacak işlere göre bir routing key belirlenir ve buna göre ilgili direct exchange ile amaca en uygun queue gidilir.
            //Fanout : Burada routing key’in bir önemi yoktur. Daha çok broadcast yayınlar için uygundur. Özellikle (MMO) oyunlarda top10 güncellemeleri ve global duyurular için kullanılır. Yine real-time spor haberleri gibi yayınlarda fanout exchange kullanılır.
            //Topic : Bir route mesajın bir veya daha çok queue’ye gitmesi amacı ile kullanılır. Publish/Subscribe pattern’in bir varyasyonudur. Eğer ilgili sorun birkaç consumer’i alakadar ediyor ise, hangi çeşit mesajı almak istediklerini belirlemek için Topic Exchange kullanılmalıdır.
            //Headers : bu exchange de routing key’i kullanmaz ve message headers’daki birkaç özellik ve tanımlama ile doğru queue’ye iletim yapar. Header üzerindeki attributeler ile  queue üzerindeki attributelerin, tamamının değerlerinin birbirini tutması gerekmektedir. 
            cmbDeclareExchangeType.Items.Add("direct");
            cmbDeclareExchangeType.Items.Add("fanout");
            cmbDeclareExchangeType.Items.Add("headers");
            cmbDeclareExchangeType.Items.Add("topic");

            cmbDeclareExchangeType.SelectedIndex = 0;

            UpdateConnectionStatus();
        }

        private void btnDeclareQueue_Click(object sender, EventArgs e)
        {
            //durable :  in-memory mi yoksa fiziksel olarak mı saklanacağı belirlenir. Genel de RabbitMQ’da hız amcı ile ilgili queuelerin memory’de saklanması tercih edilse de sunucunun restart olması durumunda ilgili mesajların kaybolmasından dolayı da, hızdan ödün verilerek fiziksel olarak bir hard diskte saklanması tercih edilebilir.
            //exclusive : diğer connectionlar ile kullanılması izni belirler. bu bağlantı kapandığında silinir
            //autoDelete : Eğer queue deleted false olarak işaretlenmiş ise ve tüm consumerlar bunu kullanmayı bitirmiş ise ya da son consumer iptal edilmiş veya channel kapanmış ise silinmez
            channel.QueueDeclare(txtDeclareQueueName.Text, durable: cbDurable.Checked, exclusive: cbExclusive.Checked, autoDelete: cbAutoDelete.Checked); 
        }

        private void btnBindQueue_Click(object sender, EventArgs e)
        {
            channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchangeName.Text, txtDeclareRoutingKey.Text); 
        }

        private void WriteDataToExchange(string ExchangeName, string RoutingKey, object data)
        {
            byte[] dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            channel.BasicPublish(ExchangeName, RoutingKey, null, dataArr);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            for (int i = 0; i < nudRepeat.Value; i++)
            {
                if (cbUseCounter.Checked)
                {
                    message = (i + 1) + txtMessage.Text;
                }
                WriteDataToExchange(txtExchangeName.Text, txtRoutingKey.Text, message);
            }

        }
    }
}
