﻿namespace UconnHealthVaultServer.Enums
{
    public static class HealthItemXmlEnum
    {
        public const string Person = "<thing><thing-id></thing-id><type-id name=\"Personal Demographic Information\">92ba621e-66b3-4a01-bd73-74844aed4f5b</type-id><thing-state>Active</thing-state><flags>0</flags><eff-date></eff-date><data-xml><personal><name><full>digital subdivide</full><first>digital</first><last>subdivide</last></name><birthdate><date><y>1987</y><m>2</m><d>28</d></date></birthdate></personal><common /></data-xml></thing>";
        public const string Demographic = "<thing><thing-id></thing-id><type-id name=\"Basic Demographic Information\">bf516a61-5252-4c28-a979-27f45f62f78d</type-id><thing-state>Active</thing-state><flags>2</flags><eff-date></eff-date><data-xml><basic><gender>m</gender><birthyear>1987</birthyear><country>US</country><postcode>06489</postcode></basic><common /></data-xml></thing>";
        public const string Height = "<thing><thing-id></thing-id><type-id name=\"Height Measurement\">40750a6a-89b2-455c-bd8d-b420a4cb500b</type-id><thing-state>Active</thing-state><flags>0</flags><eff-date></eff-date><data-xml><height><when><date><y>2013</y><m>10</m><d>10</d></date></when><value><m>1.0049999971043997</m><display units=\"in\" units-code=\"in\" text=\"6 ft 3 in\">75</display></value></height><common /></data-xml></thing>";
        public const string Weight = "<thing><thing-id></thing-id><type-id name=\"Weight Measurement\">3d34d87e-7fc1-4153-800f-f56592cb0d17</type-id><thing-state>Active</thing-state><flags>0</flags><eff-date></eff-date><data-xml><weight><when><date><y>2013</y><m>10</m><d>12</d></date></when><value><kg>0</kg></value></weight><common/></data-xml></thing>";
        public const string Medication = "<thing><thing-id></thing-id><type-id name=\"Medication\">5C5F1223-F63C-4464-870C-3E36BA471DEF</type-id><thing-state>Active</thing-state><flags>2</flags><eff-date></eff-date><data-xml><medication><name>Amoxicillin40</name><date-discontinued><structured><date><y>2005</y><m>1</m><d>15</d></date><time><h>0</h><m>0</m><s>0</s><f>0</f></time></structured></date-discontinued><is-prescribed>true</is-prescribed><indication>Feeling cold still</indication><dose-value><description>0.6</description></dose-value><frequency>0.5 to 0.6 per day.</frequency><instructions>Take after dinner.</instructions></medication><common /></data-xml><updated-end-date>2005-01-15T00:00:00</updated-end-date></thing>";
        public const string Emotion = "<thing><thing-id></thing-id><type-id name=\"Emotional State\">4b7971d6-e427-427d-bf2c-2fbcf76606b3</type-id><thing-state>Active</thing-state><flags>0</flags><eff-date></eff-date><data-xml><emotion><when><date><y>2013</y><m>10</m><d>12</d></date></when></emotion><common /></data-xml></thing>";
        public const string Vital = "<thing><thing-id></thing-id><type-id name=\"Vital Signs\">73822612-c15f-4b49-9e65-6af369e55c65</type-id><thing-state>Active</thing-state><flags>0</flags><eff-date></eff-date><data-xml><vital-signs><when><date><y>2013</y><m>10</m><d>12</d></date></when></vital-signs><common/></data-xml></thing>";
        public const string Exercise = "<thing><thing-id></thing-id><type-id name=\"Exercise\">85a21ddb-db20-4c65-8d30-33c899ccf612</type-id><thing-state>Active</thing-state><flags>0</flags><eff-date></eff-date><data-xml><exercise><when><structured><date><y>2013</y><m>10</m><d>7</d></date></structured></when><activity><text>Rope jumping</text><code><value>RopeJumping</value><family>wc</family><type>exercise-activities</type><version>1</version></code></activity><distance><m>3218.688</m><display units=\"mi\" units-code=\"mi\">2</display></distance><duration>20</duration><detail><name><value>Steps_count</value><family>wc</family><type>exercise-detail-names</type></name><value><value>300</value><units><text>Count</text><code><value>Count</value><family>wc</family><type>exercise-units</type><version>1</version></code></units></value></detail></exercise><common /></data-xml></thing>";
        public const string FileItem = "<thing><thing-id></thing-id><type-id name=\"File\">bd0403c5-4ae2-4b0e-a8db-1888678e4528</type-id><thing-state>Active</thing-state><flags>0</flags><eff-date></eff-date><data-xml><file><name></name><size></size><content-type><text></text></content-type></file><common><note>test file</note></common></data-xml></thing>";
    }
}