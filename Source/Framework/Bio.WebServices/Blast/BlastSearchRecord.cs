﻿using System.Collections.Generic;

namespace Bio.Web.Blast
{
    /// <summary>
    /// A single result from a sequence search, such as any of the various flavors of BLAST.
    /// This is referred to as an Iteration in the BLAST XML schema; some flavors (such as
    /// PSI-BLAST) can combine multiple iterations into one XML document.
    /// </summary>
    public class BlastSearchRecord
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public BlastSearchRecord()
        {
            this.Hits = new List<Hit>();
        }

        /// <summary>
        /// The set of hits associated with this iteration
        /// </summary>
        public IList<Hit> Hits { get; private set; }

        /// <summary>
        /// The index for this iteration
        /// </summary>
        public int IterationNumber { get; set; }

        /// <summary>
        /// The ID of the query which generated this iteration
        /// </summary>
        public string IterationQueryId { get; set; }

        /// <summary>
        /// The definition of the query which generated this iteration
        /// </summary>
        public string IterationQueryDefinition { get; set; }

        /// <summary>
        /// The length of the query which generated this iteration
        /// </summary>
        public int IterationQueryLength { get; set; }

        /// <summary>
        /// A human-readable message associated with this iteration
        /// </summary>
        public string IterationMessage { get; set; }

        /// <summary>
        /// The statistics returned for this iteration
        /// </summary>
        public BlastStatistics Statistics { get; set; }
    }
}
