/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFHIRDatastore operation.
    /// Gets the properties associated with the FHIR datastore, including the datastore ID,
    /// datastore ARN, datastore name, datastore status, created at, datastore type version,
    /// and datastore endpoint.
    /// </summary>
    public partial class DescribeFHIRDatastoreRequest : AmazonHealthLakeRequest
    {
        private string _datastoreId;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The AWS-generated datastore id. This is part of the ‘CreateFHIRDatastore’ output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

    }
}