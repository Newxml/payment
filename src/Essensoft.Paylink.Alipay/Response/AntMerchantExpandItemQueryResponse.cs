﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandItemQueryResponse.
    /// </summary>
    public class AntMerchantExpandItemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<ItemModel> ItemList { get; set; }
    }
}