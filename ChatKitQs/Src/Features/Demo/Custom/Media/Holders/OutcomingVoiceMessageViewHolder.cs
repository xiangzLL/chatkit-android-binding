﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Stfalcon.Chatkit.Messages;
using Java.Lang;
using ChatKitQs.Src.Utils;
using Com.Stfalcon.Chatkit.Utils;

namespace ChatKitQs.Src.Features.Demo.Custom.Media.Holders
{
    public class OutcomingVoiceMessageViewHolder : MessageHolders.OutcomingTextMessageViewHolder
    {
        private TextView tvDuration;
        private TextView tvTime;
        public OutcomingVoiceMessageViewHolder(View p0) : base(p0)
        {
            tvDuration = p0.FindViewById<TextView>(Resource.Id.duration);
            tvTime = p0.FindViewById<TextView>(Resource.Id.time);
        }

        public override void OnBind(Java.Lang.Object p0)
        {
            base.OnBind(p0);
            var message = (ChatKitQs.Src.Common.Data.Models.Message)p0;
            tvDuration.Text =
                FormatUtils.GetDurationString(message.MessageVoice.Duration);
            tvTime.Text = DateFormatter.Format(message.CreatedAt, DateFormatter.Template.Time);
        }
    }
}