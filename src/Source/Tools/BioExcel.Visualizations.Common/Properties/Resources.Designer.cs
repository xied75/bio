﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiodexExcel.Visualizations.Common.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BiodexExcel.Visualizations.Common.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap about {
            get {
                object obj = ResourceManager.GetObject("about", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto Detect.
        /// </summary>
        internal static string AutoDetectString {
            get {
                return ResourceManager.GetString("AutoDetectString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://blast2.cloudapp.net/BlastService.svc.
        /// </summary>
        internal static string AZURE_URI {
            get {
                return ResourceManager.GetString("AZURE_URI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Bio Extension for Excel.
        /// </summary>
        internal static string CAPTION {
            get {
                return ResourceManager.GetString("CAPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://bio.codeplex.com.
        /// </summary>
        internal static string CodeplexURL {
            get {
                return ResourceManager.GetString("CodeplexURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consensus Threshold.
        /// </summary>
        internal static string CONSENSUS_THRESHOLD {
            get {
                return ResourceManager.GetString("CONSENSUS_THRESHOLD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to nr.
        /// </summary>
        internal static string DATABASE_NR {
            get {
                return ResourceManager.GetString("DATABASE_NR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to nt.
        /// </summary>
        internal static string DATABASE_NT {
            get {
                return ResourceManager.GetString("DATABASE_NT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to em_rel.
        /// </summary>
        internal static string EM_REL {
            get {
                return ResourceManager.GetString("EM_REL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The worksheet {0} is missing certain header information. Please select the genomic attributes and their corresponding columns in your selected worksheet.
        /// </summary>
        internal static string HEADER_SUBTEXT {
            get {
                return ResourceManager.GetString("HEADER_SUBTEXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Intersect_img1 {
            get {
                object obj = ResourceManager.GetObject("Intersect_img1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Intersect_Img2 {
            get {
                object obj = ResourceManager.GetObject("Intersect_Img2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Intersect Inputs.
        /// </summary>
        internal static string INTERSECT_INPUT {
            get {
                return ResourceManager.GetString("INTERSECT_INPUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns entire intervals from the first query that overlap the second query. 
        ///The returned intervals are completely unchanged, and this option only filters 
        ///out intervals that do not overlap with the second query..
        /// </summary>
        internal static string Intersect_OverlappingIntervals {
            get {
                return ResourceManager.GetString("Intersect_OverlappingIntervals", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns intervals that indicate the exact base pair overlap between the first 
        ///query and the second query. The intervals returned are from the first query, 
        ///and all fields besides start and end are guaranteed to remain unchanged..
        /// </summary>
        internal static string Intersect_OverlappingPiecesofIntervals {
            get {
                return ResourceManager.GetString("Intersect_OverlappingPiecesofIntervals", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Intervals with No overlap.
        /// </summary>
        internal static string INTERVAL_NO_OVERLAP {
            get {
                return ResourceManager.GetString("INTERVAL_NO_OVERLAP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-overlapping pieces of intervals.
        /// </summary>
        internal static string INTERVAL_OVERLAP {
            get {
                return ResourceManager.GetString("INTERVAL_OVERLAP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of sequences per sheet must be numeric..
        /// </summary>
        internal static string INVALID_SEQ_PER_SHEET {
            get {
                return ResourceManager.GetString("INVALID_SEQ_PER_SHEET", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid .
        /// </summary>
        internal static string INVALID_TEXT {
            get {
                return ResourceManager.GetString("INVALID_TEXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please choose Chromsome ID, Start and Stop columns.
        /// </summary>
        internal static string MANDATORY_COLUMNS {
            get {
                return ResourceManager.GetString("MANDATORY_COLUMNS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Match Score.
        /// </summary>
        internal static string MATCH_SCORE {
            get {
                return ResourceManager.GetString("MATCH_SCORE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter only positive values..
        /// </summary>
        internal static string MAX_COLUMN_ERROR {
            get {
                return ResourceManager.GetString("MAX_COLUMN_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Merge Threshold.
        /// </summary>
        internal static string MERGE_THRESHOLD {
            get {
                return ResourceManager.GetString("MERGE_THRESHOLD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Minimum overlap value..
        /// </summary>
        internal static string MIN_OVERLAP_ERROR {
            get {
                return ResourceManager.GetString("MIN_OVERLAP_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select atleast {0} sheet(s) for alignment.
        /// </summary>
        internal static string MINIMUM_SELECT_HEADER {
            get {
                return ResourceManager.GetString("MINIMUM_SELECT_HEADER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mismatch Score.
        /// </summary>
        internal static string MISMATCH_SCORE {
            get {
                return ResourceManager.GetString("MISMATCH_SCORE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to nr.25.
        /// </summary>
        internal static string NR_25 {
            get {
                return ResourceManager.GetString("NR_25", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please choose one value per column.
        /// </summary>
        internal static string ONE_COLUMN {
            get {
                return ResourceManager.GetString("ONE_COLUMN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overlapping Intervals.
        /// </summary>
        internal static string OVERLAPPING_INTERVALS {
            get {
                return ResourceManager.GetString("OVERLAPPING_INTERVALS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overlapping pieces of  Intervals.
        /// </summary>
        internal static string OVERLAPPING_PIECES_OF_INTERVALS {
            get {
                return ResourceManager.GetString("OVERLAPPING_PIECES_OF_INTERVALS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select atleast {0} or more sheets..
        /// </summary>
        internal static string SELECT_SHEET_MESSAGE {
            get {
                return ResourceManager.GetString("SELECT_SHEET_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum number of sheets allowed to be selected: {0}.
        /// </summary>
        internal static string SHEET_SELECT_LIMIT {
            get {
                return ResourceManager.GetString("SHEET_SELECT_LIMIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Subtract_img1 {
            get {
                object obj = ResourceManager.GetObject("Subtract_img1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subtract Inputs.
        /// </summary>
        internal static string SUBTRACT_INPUT {
            get {
                return ResourceManager.GetString("SUBTRACT_INPUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns intervals from the first query that have the intervals from the second 
        ///query removed. Any overlapping base pairs are removed from the range of the interval. 
        ///All fields besides start and end are guaranteed to remain unchanged..
        /// </summary>
        internal static string Subtract_WithNonOverlappingPiecesofInterval {
            get {
                return ResourceManager.GetString("Subtract_WithNonOverlappingPiecesofInterval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns entire intervals from the first query that do not overlap the second query. 
        ///The returned intervals are completely unchanged, and this option only filters out 
        ///intervals that overlap with the second query..
        /// </summary>
        internal static string Subtract_WithNoOverlap {
            get {
                return ResourceManager.GetString("Subtract_WithNoOverlap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Subtrtact_img2 {
            get {
                object obj = ResourceManager.GetObject("Subtrtact_img2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  value.
        /// </summary>
        internal static string VALUE_TEXT {
            get {
                return ResourceManager.GetString("VALUE_TEXT", resourceCulture);
            }
        }
    }
}
