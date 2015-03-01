﻿// This source code is dual-licensed under the Apache License, version
// 2.0, and the Mozilla Public License, version 1.1.
//
// The APL v2.0:
//
//---------------------------------------------------------------------------
//   Copyright (C) 2007-2014 GoPivotal, Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//---------------------------------------------------------------------------
//
// The MPL v1.1:
//
//---------------------------------------------------------------------------
//  The contents of this file are subject to the Mozilla Public License
//  Version 1.1 (the "License"); you may not use this file except in
//  compliance with the License. You may obtain a copy of the License
//  at http://www.mozilla.org/MPL/
//
//  Software distributed under the License is distributed on an "AS IS"
//  basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
//  the License for the specific language governing rights and
//  limitations under the License.
//
//  The Original Code is RabbitMQ.
//
//  The Initial Developer of the Original Code is GoPivotal, Inc.
//  Copyright (c) 2007-2014 GoPivotal, Inc.  All rights reserved.
//---------------------------------------------------------------------------

namespace RabbitMQ.Client
{
    sealed class SequentialConsumerDispatcher : IConsumerDispatcher
    {
        private IModel model;
        public SequentialConsumerDispatcher(IModel model)
        {
            this.model = model;
        }

        public void HandleBasicConsumeOk(IBasicConsumer consumer,
                             string consumerTag)
        {
            consumer.HandleBasicConsumeOk(consumerTag);
        }

        public void HandleBasicDeliver(IBasicConsumer consumer,
                            string consumerTag,
                            ulong deliveryTag,
                            bool redelivered,
                            string exchange,
                            string routingKey,
                            IBasicProperties basicProperties,
                            byte[] body)
        {
            consumer.HandleBasicDeliver(consumerTag, deliveryTag, redelivered,
                                        exchange, routingKey, basicProperties, body);
        }

        public void HandleBasicCancelOk(IBasicConsumer consumer,
                            string consumerTag)
        {
            consumer.HandleBasicCancelOk(consumerTag);
        }

        public void HandleBasicCancel(IBasicConsumer consumer,
                          string consumerTag)
        {
            consumer.HandleBasicCancel(consumerTag);
        }
    }
}