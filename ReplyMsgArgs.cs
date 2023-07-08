using System;
using Newtonsoft.Json;

namespace WhatsAppNETAPI
{
	public class ReplyMsgArgs
	{
		public string send_to { get; set; }

		public string message { get; set; }

		public string type { get; set; }

		public string timestamp { get; set; }

		public string quotedMessageId { get; set; }

		public string sessionId { get; set; }

		public ReplyMsgArgs(string contact, Sticker sticker, string quotedMessageId)
		{
			send_to = contact;
			message = JsonConvert.SerializeObject(sticker);
			this.quotedMessageId = quotedMessageId;
			type = "sticker";
			timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		}

		public ReplyMsgArgs(string contact, Location location, string quotedMessageId)
		{
			send_to = contact;
			message = JsonConvert.SerializeObject(location);
			this.quotedMessageId = quotedMessageId;
			type = "location";
			timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		}

		public ReplyMsgArgs(string contact, string message, string quotedMessageId)
		{
			send_to = contact;
			this.message = message;
			this.quotedMessageId = quotedMessageId;
			type = "text";
			timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		}
	}
}
