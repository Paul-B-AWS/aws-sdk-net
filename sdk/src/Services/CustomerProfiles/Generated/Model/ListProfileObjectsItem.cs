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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// A ProfileObject in a list of ProfileObjects.
    /// </summary>
    public partial class ListProfileObjectsItem
    {
        private string _object;
        private string _objectTypeName;
        private string _profileObjectUniqueKey;

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        /// A JSON representation of a ProfileObject that belongs to a profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256000)]
        public string Object
        {
            get { return this._object; }
            set { this._object = value; }
        }

        // Check to see if Object property is set
        internal bool IsSetObject()
        {
            return this._object != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// Specifies the kind of object being added to a profile, such as "Salesforce-Account."
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ObjectTypeName
        {
            get { return this._objectTypeName; }
            set { this._objectTypeName = value; }
        }

        // Check to see if ObjectTypeName property is set
        internal bool IsSetObjectTypeName()
        {
            return this._objectTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileObjectUniqueKey. 
        /// <para>
        /// The unique identifier of the ProfileObject generated by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProfileObjectUniqueKey
        {
            get { return this._profileObjectUniqueKey; }
            set { this._profileObjectUniqueKey = value; }
        }

        // Check to see if ProfileObjectUniqueKey property is set
        internal bool IsSetProfileObjectUniqueKey()
        {
            return this._profileObjectUniqueKey != null;
        }

    }
}