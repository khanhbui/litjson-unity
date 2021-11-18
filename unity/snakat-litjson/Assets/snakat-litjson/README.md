# snakat-litjson

A *.Net* library to handle conversions from and to JSON (JavaScript Object
Notation) strings.

This is a modifier of [*litjson*](https://github.com/LitJSON/litjson) that supports the following features.

# Features

## Set alias for serializable field/property
You can serialize/deserialize a member with a custom name.

```CSharp
[JsonSerialize ("float_value")]
public float FloatValue;
```

```json
{
  "float_value": 0.0
}
```

## Opt out serializing a field/property
You can hide a member from serializing.

```CSharp
[JsonIgnore]
public double DoubleValue;
```

```json
{
}
```

## Serialize a non-public field/property
You can serialize/deserialize a non-public member.

```CSharp
[JsonSerialize]
private float FloatValue;
```

```json
{
  "FloatValue": 0.0
}
```
