﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QFTEST
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    // Generate Id:b989fc9d-e70a-4e65-b7e1-e74d09415420
    public partial class UIHomePanel
    {
        
        public const string NAME = "UIHomePanel";
        
        private UIHomePanelData mPrivateData = null;
        
        public UIHomePanelData Data
        {
            get
            {
                return mData;
            }
        }
        
        UIHomePanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIHomePanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            mData = null;
        }
    }
}
