﻿using System;
using System.Collections.Generic;
using Bio.Algorithms.Alignment;
using Bio.Util;
using System.Linq;

namespace Bio.IO.SAM
{
    /// <summary>
    /// Class to hold Reads or aligned sequence or query sequence in SAM Alignment.
    /// </summary>
    public class SAMAlignedSequence : IAlignedSequence
    {
        /// <summary>
        /// SAM aligned sequence header.
        /// </summary>
        private readonly SAMAlignedSequenceHeader seqHeader;

        /// <summary>
        /// Holds metadata of this aligned sequence.
        /// </summary>
        private readonly Dictionary<string, object> metadata;

        /// <summary>
        /// Holds aligned sequence.
        /// </summary>
        private List<ISequence> sequences;

        /// <summary>
        /// Gets or sets read/query/aligned sequence.
        /// </summary>
        public ISequence QuerySequence
        {
            get
            {
                return this.sequences == null || this.sequences.Count == 0 ? null : this.sequences[0];
            }
            set
            {
                if (sequences == null)
                    sequences = new List<ISequence>();

                if (sequences.Count == 0)
                    sequences.Add(value);
                else
                    sequences[0] = value;
            }
        }

        /// <summary>
        /// Query pair name if paired; or Query name if unpaired.
        /// </summary>  
        public string QName
        {
            get
            {
                return seqHeader.QName;
            }
            set
            {
                seqHeader.QName = value;
            }
        }

        /// <summary>
        /// SAM flags.
        /// <see cref="SAMFlags"/>
        /// </summary>
        public SAMFlags Flag
        {
            get
            {
                return seqHeader.Flag;
            }
            set
            {
                seqHeader.Flag = value;
            }
        }

        /// <summary>
        /// Reference sequence name.
        /// </summary>
        public string RName
        {
            get
            {
                return seqHeader.RName;
            }
            set
            {
                seqHeader.RName = value;
            }
        }


        /// <summary>
        /// Is this read a special dummy read?  
        /// 
        /// These read types are a special type in later BAM file formats that are designed to hold
        /// annotation data. They are identified as having SEQ set to *, FLAG bits 0x100 and 0x200 set
        ///  (secondary and filtered), and a CT tag.
        /// </summary>
        public bool IsDummyRead
        {
            get
            {
                return QuerySequence == null && 
                    Flag.HasFlag(SAMFlags.QualityCheckFailure) && 
                    Flag.HasFlag(SAMFlags.NonPrimeAlignment) && 
                    OptionalFields.Any(p=> p.Tag == "CT");
            }
        }

        /// <summary>
        /// Sets the RName using a name that has already been validated as valid, and so does not need to be checked
        /// against the regular expression.
        /// </summary>
        /// <param name="name"></param>
        public void SetPreValidatedRName(string name)
        {
            seqHeader.SetPreValidatedRName(name);
        }

        /// <summary>
        /// One-based leftmost position/coordinate of the clipped sequence.
        /// </summary>
        public int Pos
        {
            get
            {
                return seqHeader.Pos;
            }
            set
            {
                seqHeader.Pos = value;
            }
        }

        /// <summary>
        /// Gets bin depending on POS and CIGAR values.
        /// </summary>
        public int Bin
        {
            get
            {
                return seqHeader.Bin;
            }

            internal set
            {
                seqHeader.Bin = value;
            }
        }

        /// <summary>
        /// Gets one based alignment end position of reference sequence depending on CIGAR Value.
        /// </summary>
        public int RefEndPos
        {
            get
            {
                return seqHeader.RefEndPos;
            }
        }

        /// <summary>
        /// Mapping quality (phred-scaled posterior probability that the 
        /// mapping position of this read is incorrect).
        /// </summary>
        public int MapQ
        {
            get
            {

                return seqHeader.MapQ;
            }
            set
            {
                seqHeader.MapQ = value;
            }
        }

        /// <summary>
        /// Extended CIGAR string.
        /// </summary>
        public string CIGAR
        {
            get
            {
                return seqHeader.CIGAR;
            }

            set
            {
                seqHeader.CIGAR = value;
            }
        }

        /// <summary>
        /// Set a pre-validated extended cigar string, the alignment length and bin are still calculated
        /// </summary>
        /// <param name="value"></param>
        public void SetPreValidatedCIGAR(string value)
        {
            seqHeader.SetPreValidatedCIGAR(value);
        }

        /// <summary>
        /// Mate reference sequence name. 
        /// </summary>
        public string MRNM
        {
            get
            {
                return seqHeader.MRNM;
            }

            set
            {
                seqHeader.MRNM = value;
            }
        }

        /// <summary>
        /// Set the mate reference sequence name assuming the value is already valid.
        /// </summary>
        /// <param name="item"></param>
        public void SetPreValidatedMRNM(string item)
        {
            seqHeader.SetPreValidatedMRNM(item);
        }

        /// <summary>
        /// One-based leftmost mate position of the clipped sequence.
        /// </summary>
        public int MPos
        {
            get
            {
                return seqHeader.MPos;
            }

            set
            {
                seqHeader.MPos = value;
            }
        }

        /// <summary>
        /// Inferred insert size.
        /// </summary>
        public int ISize
        {
            get
            {
                return seqHeader.ISize;
            }

            set
            {
                seqHeader.ISize = value;
            }
        }

        /// <summary>
        /// Optional fields.
        /// </summary>
        public IList<SAMOptionalField> OptionalFields
        {
            get
            {
                return seqHeader.OptionalFields;
            }
        }

        /// <summary>
        /// Metadata of this aligned sequence.
        /// SAMAlignedSequenceHeader is stored with the key "SAMAlignedSequenceHeader".
        /// </summary>
        public IDictionary<string, object> Metadata
        {
            get
            {
                return metadata;
            }
        }

        /// <summary>
        /// Always returns QuerySequence in a list.
        /// </summary>
        public IList<ISequence> Sequences
        {
            get
            {
                return this.sequences ?? (this.sequences = new List<ISequence>());
            }
        }

        /// <summary>
        /// Creates new instance of SAMAlignedSequence.
        /// </summary>
        public SAMAlignedSequence() : this(new SAMAlignedSequenceHeader()) { }

        /// <summary>
        /// Creates new instance of SAMAlignedSequence with specified SAMAlignedSequenceHeader.
        /// </summary>
        /// <param name="seqHeader"></param>
        public SAMAlignedSequence(SAMAlignedSequenceHeader seqHeader)
        {
            this.seqHeader = seqHeader;
            metadata = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            metadata.Add(Helper.SAMAlignedSequenceHeaderKey, seqHeader);
        }

        /// <summary>
        /// Gets encoded quality scores.
        /// </summary>
        public byte[] GetEncodedQualityScores()
        {
            QualitativeSequence seq = QuerySequence as QualitativeSequence;
            return seq != null ? seq.GetEncodedQualityScores() : new byte[0];
        }

        /// <summary>
        /// Gets Phred base quality scores.
        /// </summary>
        public int[] GetQualityScores()
        {
            QualitativeSequence seq = QuerySequence as QualitativeSequence;
            return seq != null ? seq.GetPhredQualityScores() : new int[0];
        }
    }
}
