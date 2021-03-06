﻿using System.Windows.Forms;
using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class CastDataGridView : BindingDataGridView<Cast>
    {
        public CastDataGridView() => InitializeComponent();

        public void SetColumns()
        {
            SetColumnsCore(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"CharaName",
                    HeaderText = @"角色名称",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"VoiceActor",
                    HeaderText = @"声优名称",
                    SortMode = DataGridViewColumnSortMode.NotSortable
                }
            });
        }
        protected override bool IsTheSameItem(Cast t1, Cast t2) => t1.VoiceActorID == t2.VoiceActorID && t1.CharaName == t2.CharaName;
    }
}