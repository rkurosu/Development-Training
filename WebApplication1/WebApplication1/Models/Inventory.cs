//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Inventory
    {
        public int 商品番号 { get; set; }
        public string 商品名 { get; set; }
        [DisplayName("価格(円)")]
        public int 価格 { get; set; }
        [DisplayName("在庫数")]
        public Nullable<int> 個数 { get; set; }
        [DisplayName("小計(円)")]
        public Nullable<int> 小計 { get; set; }
        public Nullable<System.DateTime> 最終更新 { get; set; }
    }
}
