﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionScript
{
    public static class MessageCodes
    {
        public static string SyntaxError => "SC001";
        public static string MisplacedEndIf => "SC002";
        public static string IncompleteWhile => "SC003";
        public static string MisplacedWend => "SC004";
        public static string UndefinedSubrutine => "SC005";
        public static string UndefinedVariable => "SC006";
        public static string SubrutineRedefinition => "SC007";
        public static string SubrutineRedefined => "SC008";
        public static string UndefinedLabel => "SC009";
        public static string InvalidBreak => "SC010";
        public static string InvalidLabelName => "SC011";
        public static string OrphanedElse => "SC012";

        public static string DebuggerNotAttached => "DBG001";
    }
}
