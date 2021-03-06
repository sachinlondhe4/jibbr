﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jabbot;
using Jabbot.Models;
using Jabbot.Sprockets.Core;

namespace HelpSprocket
{
	public class Help : ISprocket
	{
		public bool Handle(ChatMessage message, IBot bot)
		{
			var acceptedCommands = new string[] { bot.Name + " help", "@" + bot.Name + " help" };

			if (acceptedCommands.Contains(message.Content.Trim()))
			{
				bot.PrivateReply(message.Sender, "A list of commands this bot currently supports:\n\thelp");

				return true;
			}

			return false;
		}
	}
}
