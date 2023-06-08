﻿// <auto-generated/>
#nullable enable
#pragma warning disable CS0162 // Unreachable code
#pragma warning disable CS0164 // Unreferenced label
#pragma warning disable CS0219 // Variable assigned but never used

namespace GravyVrc.Summoner.Nfc
{
    partial class NfcSummoner
    {
        /// <remarks>
        /// Pattern explanation:<br/>
        /// <code>
        /// ○ Match if at the beginning of the string.<br/>
        /// ○ Match the string "gravyvrc-summoner:".<br/>
        /// ○ 1st capture group.<br/>
        ///     ○ Match with 3 alternative expressions.<br/>
        ///         ○ Match a sequence of expressions.<br/>
        ///             ○ 2nd capture group.<br/>
        ///                 ○ Match the string "int".<br/>
        ///             ○ Match '/'.<br/>
        ///             ○ 3rd capture group.<br/>
        ///                 ○ Match '-' atomically, optionally.<br/>
        ///                 ○ Match a Unicode digit atomically at least once.<br/>
        ///         ○ Match a sequence of expressions.<br/>
        ///             ○ 4th capture group.<br/>
        ///                 ○ Match the string "bool".<br/>
        ///             ○ Match '/'.<br/>
        ///             ○ 5th capture group.<br/>
        ///                 ○ Match with 2 alternative expressions.<br/>
        ///                     ○ Match the string "true".<br/>
        ///                     ○ Match the string "false".<br/>
        ///         ○ Match a sequence of expressions.<br/>
        ///             ○ 6th capture group.<br/>
        ///                 ○ Match the string "float".<br/>
        ///             ○ Match '/'.<br/>
        ///             ○ 7th capture group.<br/>
        ///                 ○ Match '-' atomically, optionally.<br/>
        ///                 ○ Match a Unicode digit greedily at least once.<br/>
        ///                 ○ Match '.' atomically, optionally.<br/>
        ///                 ○ Match a Unicode digit atomically any number of times.<br/>
        /// ○ Match '/'.<br/>
        /// ○ 8th capture group.<br/>
        ///     ○ Match any character other than a space character atomically at least once.<br/>
        /// ○ Match if at the end of the string or if before an ending newline.<br/>
        /// </code>
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Text.RegularExpressions.Generator", "7.0.8.17405")]
        private static partial global::System.Text.RegularExpressions.Regex ParameterRgx() => global::System.Text.RegularExpressions.Generated.ParameterRgx_0.Instance;
    }
}

namespace System.Text.RegularExpressions.Generated
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Threading;

    /// <summary>Custom <see cref="Regex"/>-derived type for the ParameterRgx method.</summary>
    [GeneratedCodeAttribute("System.Text.RegularExpressions.Generator", "7.0.8.17405")]
    file sealed class ParameterRgx_0 : Regex
    {
        /// <summary>Cached, thread-safe singleton instance.</summary>
        internal static readonly ParameterRgx_0 Instance = new();
    
        /// <summary>Initializes the instance.</summary>
        private ParameterRgx_0()
        {
            base.pattern = "^gravyvrc-summoner:((int)\\/(-?\\d+)|(bool)\\/(true|false)|(float)\\/(-?\\d+\\.?\\d*))\\/(\\S+)$";
            base.roptions = RegexOptions.None;
            ValidateMatchTimeout(Utilities.s_defaultTimeout);
            base.internalMatchTimeout = Utilities.s_defaultTimeout;
            base.factory = new RunnerFactory();
            base.capsize = 9;
        }
    
        /// <summary>Provides a factory for creating <see cref="RegexRunner"/> instances to be used by methods on <see cref="Regex"/>.</summary>
        private sealed class RunnerFactory : RegexRunnerFactory
        {
            /// <summary>Creates an instance of a <see cref="RegexRunner"/> used by methods on <see cref="Regex"/>.</summary>
            protected override RegexRunner CreateInstance() => new Runner();
        
            /// <summary>Provides the runner that contains the custom logic implementing the specified regular expression.</summary>
            private sealed class Runner : RegexRunner
            {
                /// <summary>Scan the <paramref name="inputSpan"/> starting from base.runtextstart for the next match.</summary>
                /// <param name="inputSpan">The text being scanned by the regular expression.</param>
                protected override void Scan(ReadOnlySpan<char> inputSpan)
                {
                    // The pattern is anchored.  Validate the current position and try to match at it only.
                    if (TryFindNextPossibleStartingPosition(inputSpan) && !TryMatchAtCurrentPosition(inputSpan))
                    {
                        base.runtextpos = inputSpan.Length;
                    }
                }
        
                /// <summary>Search <paramref name="inputSpan"/> starting from base.runtextpos for the next location a match could possibly start.</summary>
                /// <param name="inputSpan">The text being scanned by the regular expression.</param>
                /// <returns>true if a possible match was found; false if no more matches are possible.</returns>
                private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
                {
                    int pos = base.runtextpos;
                    
                    // Any possible match is at least 25 characters.
                    if (pos <= inputSpan.Length - 25)
                    {
                        // The pattern leads with a beginning (\A) anchor.
                        if (pos == 0)
                        {
                            return true;
                        }
                    }
                    
                    // No match found.
                    base.runtextpos = inputSpan.Length;
                    return false;
                }
        
                /// <summary>Determine whether <paramref name="inputSpan"/> at base.runtextpos is a match for the regular expression.</summary>
                /// <param name="inputSpan">The text being scanned by the regular expression.</param>
                /// <returns>true if the regular expression matches at the current position; otherwise, false.</returns>
                private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
                {
                    int pos = base.runtextpos;
                    int matchStart = pos;
                    int alternation_branch = 0;
                    int alternation_starting_capturepos = 0;
                    int alternation_starting_pos = 0;
                    int capture_starting_pos = 0;
                    int capture_starting_pos1 = 0;
                    int capture_starting_pos2 = 0;
                    int capture_starting_pos3 = 0;
                    int capture_starting_pos4 = 0;
                    int capture_starting_pos5 = 0;
                    int capture_starting_pos6 = 0;
                    int capture_starting_pos7 = 0;
                    int charloop_capture_pos = 0;
                    int charloop_starting_pos = 0, charloop_ending_pos = 0;
                    ReadOnlySpan<char> slice = inputSpan.Slice(pos);
                    
                    // Match if at the beginning of the string.
                    if (pos != 0)
                    {
                        UncaptureUntil(0);
                        return false; // The input didn't match.
                    }
                    
                    // Match the string "gravyvrc-summoner:".
                    if (!slice.StartsWith("gravyvrc-summoner:"))
                    {
                        UncaptureUntil(0);
                        return false; // The input didn't match.
                    }
                    
                    // 1st capture group.
                    //{
                        pos += 18;
                        slice = inputSpan.Slice(pos);
                        capture_starting_pos = pos;
                        
                        // Match with 3 alternative expressions.
                        //{
                            alternation_starting_pos = pos;
                            alternation_starting_capturepos = base.Crawlpos();
                            
                            // Branch 0
                            //{
                                // 2nd capture group.
                                {
                                    capture_starting_pos1 = pos;
                                    
                                    // Match the string "int".
                                    if (!slice.StartsWith("int"))
                                    {
                                        goto AlternationBranch;
                                    }
                                    
                                    pos += 3;
                                    slice = inputSpan.Slice(pos);
                                    base.Capture(2, capture_starting_pos1, pos);
                                }
                                
                                // Match '/'.
                                if (slice.IsEmpty || slice[0] != '/')
                                {
                                    goto AlternationBranch;
                                }
                                
                                // 3rd capture group.
                                {
                                    pos++;
                                    slice = inputSpan.Slice(pos);
                                    capture_starting_pos2 = pos;
                                    
                                    // Match '-' atomically, optionally.
                                    {
                                        if (!slice.IsEmpty && slice[0] == '-')
                                        {
                                            slice = slice.Slice(1);
                                            pos++;
                                        }
                                    }
                                    
                                    // Match a Unicode digit atomically at least once.
                                    {
                                        int iteration = 0;
                                        while ((uint)iteration < (uint)slice.Length && char.IsDigit(slice[iteration]))
                                        {
                                            iteration++;
                                        }
                                        
                                        if (iteration == 0)
                                        {
                                            goto AlternationBranch;
                                        }
                                        
                                        slice = slice.Slice(iteration);
                                        pos += iteration;
                                    }
                                    
                                    base.Capture(3, capture_starting_pos2, pos);
                                }
                                
                                alternation_branch = 0;
                                goto AlternationMatch;
                                
                                AlternationBranch:
                                pos = alternation_starting_pos;
                                slice = inputSpan.Slice(pos);
                                UncaptureUntil(alternation_starting_capturepos);
                            //}
                            
                            // Branch 1
                            //{
                                // 4th capture group.
                                {
                                    capture_starting_pos3 = pos;
                                    
                                    // Match the string "bool".
                                    if (!slice.StartsWith("bool"))
                                    {
                                        goto AlternationBranch1;
                                    }
                                    
                                    pos += 4;
                                    slice = inputSpan.Slice(pos);
                                    base.Capture(4, capture_starting_pos3, pos);
                                }
                                
                                // Match '/'.
                                if (slice.IsEmpty || slice[0] != '/')
                                {
                                    goto AlternationBranch1;
                                }
                                
                                // 5th capture group.
                                //{
                                    pos++;
                                    slice = inputSpan.Slice(pos);
                                    capture_starting_pos4 = pos;
                                    
                                    // Match with 2 alternative expressions.
                                    //{
                                        if (slice.IsEmpty)
                                        {
                                            goto AlternationBranch1;
                                        }
                                        
                                        switch (slice[0])
                                        {
                                            case 't':
                                                // Match the string "rue".
                                                if (!slice.Slice(1).StartsWith("rue"))
                                                {
                                                    goto AlternationBranch1;
                                                }
                                                
                                                pos += 4;
                                                slice = inputSpan.Slice(pos);
                                                break;
                                                
                                            case 'f':
                                                // Match the string "alse".
                                                if (!slice.Slice(1).StartsWith("alse"))
                                                {
                                                    goto AlternationBranch1;
                                                }
                                                
                                                pos += 5;
                                                slice = inputSpan.Slice(pos);
                                                break;
                                                
                                            default:
                                                goto AlternationBranch1;
                                        }
                                    //}
                                    
                                    base.Capture(5, capture_starting_pos4, pos);
                                //}
                                
                                alternation_branch = 1;
                                goto AlternationMatch;
                                
                                AlternationBranch1:
                                pos = alternation_starting_pos;
                                slice = inputSpan.Slice(pos);
                                UncaptureUntil(alternation_starting_capturepos);
                            //}
                            
                            // Branch 2
                            //{
                                // 6th capture group.
                                {
                                    capture_starting_pos5 = pos;
                                    
                                    // Match the string "float".
                                    if (!slice.StartsWith("float"))
                                    {
                                        UncaptureUntil(0);
                                        return false; // The input didn't match.
                                    }
                                    
                                    pos += 5;
                                    slice = inputSpan.Slice(pos);
                                    base.Capture(6, capture_starting_pos5, pos);
                                }
                                
                                // Match '/'.
                                if (slice.IsEmpty || slice[0] != '/')
                                {
                                    UncaptureUntil(0);
                                    return false; // The input didn't match.
                                }
                                
                                // 7th capture group.
                                //{
                                    pos++;
                                    slice = inputSpan.Slice(pos);
                                    capture_starting_pos6 = pos;
                                    
                                    // Match '-' atomically, optionally.
                                    {
                                        if (!slice.IsEmpty && slice[0] == '-')
                                        {
                                            slice = slice.Slice(1);
                                            pos++;
                                        }
                                    }
                                    
                                    // Match a Unicode digit greedily at least once.
                                    //{
                                        charloop_starting_pos = pos;
                                        
                                        int iteration1 = 0;
                                        while ((uint)iteration1 < (uint)slice.Length && char.IsDigit(slice[iteration1]))
                                        {
                                            iteration1++;
                                        }
                                        
                                        if (iteration1 == 0)
                                        {
                                            UncaptureUntil(0);
                                            return false; // The input didn't match.
                                        }
                                        
                                        slice = slice.Slice(iteration1);
                                        pos += iteration1;
                                        
                                        charloop_ending_pos = pos;
                                        charloop_starting_pos++;
                                        goto CharLoopEnd;
                                        
                                        CharLoopBacktrack:
                                        UncaptureUntil(charloop_capture_pos);
                                        
                                        if (Utilities.s_hasTimeout)
                                        {
                                            base.CheckTimeout();
                                        }
                                        
                                        if (charloop_starting_pos >= charloop_ending_pos)
                                        {
                                            UncaptureUntil(0);
                                            return false; // The input didn't match.
                                        }
                                        pos = --charloop_ending_pos;
                                        slice = inputSpan.Slice(pos);
                                        
                                        CharLoopEnd:
                                        charloop_capture_pos = base.Crawlpos();
                                    //}
                                    
                                    // Match '.' atomically, optionally.
                                    {
                                        if (!slice.IsEmpty && slice[0] == '.')
                                        {
                                            slice = slice.Slice(1);
                                            pos++;
                                        }
                                    }
                                    
                                    // Match a Unicode digit atomically any number of times.
                                    {
                                        int iteration2 = 0;
                                        while ((uint)iteration2 < (uint)slice.Length && char.IsDigit(slice[iteration2]))
                                        {
                                            iteration2++;
                                        }
                                        
                                        slice = slice.Slice(iteration2);
                                        pos += iteration2;
                                    }
                                    
                                    base.Capture(7, capture_starting_pos6, pos);
                                    
                                    goto CaptureSkipBacktrack;
                                    
                                    CaptureBacktrack:
                                    goto CharLoopBacktrack;
                                    
                                    CaptureSkipBacktrack:;
                                //}
                                
                                alternation_branch = 2;
                                goto AlternationMatch;
                            //}
                            
                            AlternationBacktrack:
                            if (Utilities.s_hasTimeout)
                            {
                                base.CheckTimeout();
                            }
                            
                            switch (alternation_branch)
                            {
                                case 0:
                                    goto AlternationBranch;
                                case 1:
                                    goto AlternationBranch1;
                                case 2:
                                    goto CaptureBacktrack;
                            }
                            
                            AlternationMatch:;
                        //}
                        
                        base.Capture(1, capture_starting_pos, pos);
                        
                        goto CaptureSkipBacktrack1;
                        
                        CaptureBacktrack1:
                        goto AlternationBacktrack;
                        
                        CaptureSkipBacktrack1:;
                    //}
                    
                    // Match '/'.
                    if (slice.IsEmpty || slice[0] != '/')
                    {
                        goto CaptureBacktrack1;
                    }
                    
                    // 8th capture group.
                    {
                        pos++;
                        slice = inputSpan.Slice(pos);
                        capture_starting_pos7 = pos;
                        
                        // Match any character other than a space character atomically at least once.
                        {
                            int iteration3 = 0;
                            while ((uint)iteration3 < (uint)slice.Length && !char.IsWhiteSpace(slice[iteration3]))
                            {
                                iteration3++;
                            }
                            
                            if (iteration3 == 0)
                            {
                                goto CaptureBacktrack1;
                            }
                            
                            slice = slice.Slice(iteration3);
                            pos += iteration3;
                        }
                        
                        base.Capture(8, capture_starting_pos7, pos);
                    }
                    
                    // Match if at the end of the string or if before an ending newline.
                    if (pos < inputSpan.Length - 1 || ((uint)pos < (uint)inputSpan.Length && inputSpan[pos] != '\n'))
                    {
                        goto CaptureBacktrack1;
                    }
                    
                    // The input matched.
                    base.runtextpos = pos;
                    base.Capture(0, matchStart, pos);
                    return true;
                    
                    // <summary>Undo captures until it reaches the specified capture position.</summary>
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    void UncaptureUntil(int capturePosition)
                    {
                        while (base.Crawlpos() > capturePosition)
                        {
                            base.Uncapture();
                        }
                    }
                }
            }
        }

    }
    
    /// <summary>Helper methods used by generated <see cref="Regex"/>-derived implementations.</summary>
    [GeneratedCodeAttribute("System.Text.RegularExpressions.Generator", "7.0.8.17405")]
    file static class Utilities
    {
        /// <summary>Default timeout value set in <see cref="AppContext"/>, or <see cref="Regex.InfiniteMatchTimeout"/> if none was set.</summary>
        internal static readonly TimeSpan s_defaultTimeout = AppContext.GetData("REGEX_DEFAULT_MATCH_TIMEOUT") is TimeSpan timeout ? timeout : Regex.InfiniteMatchTimeout;
        
        /// <summary>Whether <see cref="s_defaultTimeout"/> is non-infinite.</summary>
        internal static readonly bool s_hasTimeout = s_defaultTimeout != Timeout.InfiniteTimeSpan;
    }
}