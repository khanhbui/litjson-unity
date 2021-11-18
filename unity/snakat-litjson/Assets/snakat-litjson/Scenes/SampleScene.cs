using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LitJson
{
    public class SampleScene : MonoBehaviour
    {
        private class SampleObject
        {
            #region Public Fields
            [JsonSerialize]
            public int IntValue;

            [JsonSerialize ("float_value")]
            public float FloatValue;

            [JsonIgnore]
            public double DoubleValue;

            public string StringValue;
            #endregion

            #region Private Fields
            [JsonSerialize]
            private int _IntValue;

            [JsonSerialize ("_float_value")]
            private float _FloatValue;

            private long _LongValue;
            #endregion

            #region Public Properties
            [JsonSerialize ("long_value")]
            public long LongValue {
                get {
                    return _LongValue;
                }
                set {
                    _LongValue = value;
                }
            }
            #endregion

            public override string ToString ()
            {
                return string.Format ("SampleObject{{IntValue={0} FloatValue={1} DoubleValue={2} StringValue={3} _IntValue={4} _FloatValue={5} _LongValue={6} LongValue={7}}}", IntValue, FloatValue, DoubleValue, StringValue, _IntValue, _FloatValue, _LongValue, LongValue);
            }
        }

        private void Start ()
        {
            var str = "{\"IntValue\":100, \"float_value\":100.1, \"DoubleValue\":102, \"StringValue\":\"a very long string\", \"_IntValue\":2, \"_float_value\":2.5, \"long_value\":1}";

            var obj = JsonMapper.ToObject<SampleObject> (str);
            Debug.LogFormat ("obj: {0}", obj);

            var json = JsonMapper.ToJson (obj);
            Debug.LogFormat ("json: {0}", json);
        }
    }
}
