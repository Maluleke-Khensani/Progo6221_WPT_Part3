﻿#pragma checksum "..\..\..\Quiz\QuizWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "020ABCE3A5720708E3A2466644B49F3BD661A452DB4933372124E9D9E53776A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CyberBot1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CyberBot1.Quiz {
    
    
    /// <summary>
    /// QuizWindow
    /// </summary>
    public partial class QuizWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Quiz\QuizWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuestionText;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Quiz\QuizWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnswerBtn1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Quiz\QuizWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnswerBtn2;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Quiz\QuizWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnswerBtn3;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Quiz\QuizWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnswerBtn4;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Quiz\QuizWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FeedbackText;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Quiz\QuizWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ScoreText;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Quiz\QuizWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RetryButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CyberBot1;component/quiz/quizwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Quiz\QuizWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 19 "..\..\..\Quiz\QuizWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToMain_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.QuestionText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.AnswerBtn1 = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Quiz\QuizWindow.xaml"
            this.AnswerBtn1.Click += new System.Windows.RoutedEventHandler(this.AnswerButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AnswerBtn2 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Quiz\QuizWindow.xaml"
            this.AnswerBtn2.Click += new System.Windows.RoutedEventHandler(this.AnswerButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AnswerBtn3 = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Quiz\QuizWindow.xaml"
            this.AnswerBtn3.Click += new System.Windows.RoutedEventHandler(this.AnswerButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AnswerBtn4 = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Quiz\QuizWindow.xaml"
            this.AnswerBtn4.Click += new System.Windows.RoutedEventHandler(this.AnswerButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FeedbackText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ScoreText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.RetryButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Quiz\QuizWindow.xaml"
            this.RetryButton.Click += new System.Windows.RoutedEventHandler(this.RetryButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

