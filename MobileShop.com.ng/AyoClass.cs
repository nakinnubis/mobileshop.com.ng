namespace MobileShop.com.ng
{
    public class AyoClass
    {
        
    }
}
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
public partial class xml
{

    private xmlBlock[] blockField;

    private bool collectionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("block")]
    public xmlBlock[] block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool collection
    {
        get
        {
            return this.collectionField;
        }
        set
        {
            this.collectionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlock
{

    private xmlBlockField[] fieldField;

    private xmlBlockStatement[] statementField;

    private string typeField;

    private string idField;

    private byte xField;

    private ushort yField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("field")]
    public xmlBlockField[] field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("statement")]
    public xmlBlockStatement[] statement
    {
        get
        {
            return this.statementField;
        }
        set
        {
            this.statementField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte x
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatement
{

    private xmlBlockStatementBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlock
{

    private xmlBlockStatementBlockMutation mutationField;

    private xmlBlockStatementBlockField[] fieldField;

    private xmlBlockStatementBlockValue[] valueField;

    private xmlBlockStatementBlockStatement[] statementField;

    private xmlBlockStatementBlockNext nextField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockMutation mutation
    {
        get
        {
            return this.mutationField;
        }
        set
        {
            this.mutationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("field")]
    public xmlBlockStatementBlockField[] field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("statement")]
    public xmlBlockStatementBlockStatement[] statement
    {
        get
        {
            return this.statementField;
        }
        set
        {
            this.statementField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNext next
    {
        get
        {
            return this.nextField;
        }
        set
        {
            this.nextField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockMutation
{

    private byte elseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @else
    {
        get
        {
            return this.elseField;
        }
        set
        {
            this.elseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValue
{

    private xmlBlockStatementBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlock
{

    private xmlBlockStatementBlockValueBlockField fieldField;

    private xmlBlockStatementBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValue
{

    private xmlBlockStatementBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockValueBlockValueBlockField fieldField;

    private xmlBlockStatementBlockValueBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockValueBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValue
{

    private xmlBlockStatementBlockValueBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockField fieldField;

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockValue
{

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockValueShadow shadowField;

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockValueShadow
{

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockValueShadowField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValue
{

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueShadow shadowField;

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueShadow
{

    private xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueShadowField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockValueBlockValueBlockValueBlockValueBlockValueBlock
{

    private string typeField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatement
{

    private xmlBlockStatementBlockStatementBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlock
{

    private xmlBlockStatementBlockStatementBlockField[] fieldField;

    private xmlBlockStatementBlockStatementBlockValue valueField;

    private xmlBlockStatementBlockStatementBlockNext nextField;

    private string typeField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("field")]
    public xmlBlockStatementBlockStatementBlockField[] field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockValue value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNext next
    {
        get
        {
            return this.nextField;
        }
        set
        {
            this.nextField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockValue
{

    private xmlBlockStatementBlockStatementBlockValueShadow shadowField;

    private xmlBlockStatementBlockStatementBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockValueShadow
{

    private xmlBlockStatementBlockStatementBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockValueShadowField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockValueBlock
{

    private xmlBlockStatementBlockStatementBlockValueBlockMutation mutationField;

    private xmlBlockStatementBlockStatementBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockValueBlockMutation mutation
    {
        get
        {
            return this.mutationField;
        }
        set
        {
            this.mutationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockStatementBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockValueBlockMutation
{

    private byte itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockValueBlockValue
{

    private xmlBlockStatementBlockStatementBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockStatementBlockValueBlockValueBlockField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNext
{

    private xmlBlockStatementBlockStatementBlockNextBlock blockField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlock
{

    private xmlBlockStatementBlockStatementBlockNextBlockField[] fieldField;

    private xmlBlockStatementBlockStatementBlockNextBlockValue valueField;

    private xmlBlockStatementBlockStatementBlockNextBlockNext nextField;

    private string typeField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("field")]
    public xmlBlockStatementBlockStatementBlockNextBlockField[] field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValue value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNext next
    {
        get
        {
            return this.nextField;
        }
        set
        {
            this.nextField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValue
{

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlock
{

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockMutation mutationField;

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockValue[] valueField;

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockMutation mutation
    {
        get
        {
            return this.mutationField;
        }
        set
        {
            this.mutationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockMutation
{

    private byte itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockValue
{

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockField fieldField;

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValue valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValue value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValue
{

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueShadow shadowField;

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueShadow
{

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueShadowField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueBlockField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockValueBlockValueBlockField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNext
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlock blockField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlock
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockField fieldField;

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValue valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValue value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValue
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueShadow shadowField;

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueShadow
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueShadowField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlock
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockField fieldField;

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValue valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValue value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValue
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueShadow shadowField;

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueShadow
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueShadowField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockField fieldField;

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValue
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueShadow shadowField;

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueShadow
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueShadowField
{

    private string nameField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueBlockField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockStatementBlockNextBlockNextBlockValueBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNext
{

    private xmlBlockStatementBlockNextBlock blockField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlock
{

    private xmlBlockStatementBlockNextBlockField[] fieldField;

    private xmlBlockStatementBlockNextBlockValue valueField;

    private xmlBlockStatementBlockNextBlockStatement statementField;

    private xmlBlockStatementBlockNextBlockNext nextField;

    private string typeField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("field")]
    public xmlBlockStatementBlockNextBlockField[] field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValue value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockStatement statement
    {
        get
        {
            return this.statementField;
        }
        set
        {
            this.statementField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNext next
    {
        get
        {
            return this.nextField;
        }
        set
        {
            this.nextField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValue
{

    private xmlBlockStatementBlockNextBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlock
{

    private xmlBlockStatementBlockNextBlockValueBlockMutation mutationField;

    private xmlBlockStatementBlockNextBlockValueBlockField fieldField;

    private xmlBlockStatementBlockNextBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockMutation mutation
    {
        get
        {
            return this.mutationField;
        }
        set
        {
            this.mutationField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockNextBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockMutation
{

    private byte itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValue
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockField fieldField;

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValue
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockField fieldField;

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValue
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueShadow shadowField;

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueShadow
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueShadowField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValue
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueShadow shadowField;

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueShadow
{

    private xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueShadowField
{

    private string nameField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockValueBlockValueBlockValueBlockValueBlockValueBlock
{

    private string typeField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockStatement
{

    private xmlBlockStatementBlockNextBlockStatementBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockStatementBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockStatementBlock
{

    private xmlBlockStatementBlockNextBlockStatementBlockField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockStatementBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockStatementBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNext
{

    private xmlBlockStatementBlockNextBlockNextBlock blockField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlock
{

    private xmlBlockStatementBlockNextBlockNextBlockMutation mutationField;

    private xmlBlockStatementBlockNextBlockNextBlockField fieldField;

    private xmlBlockStatementBlockNextBlockNextBlockValue valueField;

    private xmlBlockStatementBlockNextBlockNextBlockStatement[] statementField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockMutation mutation
    {
        get
        {
            return this.mutationField;
        }
        set
        {
            this.mutationField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockValue value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("statement")]
    public xmlBlockStatementBlockNextBlockNextBlockStatement[] statement
    {
        get
        {
            return this.statementField;
        }
        set
        {
            this.statementField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockMutation
{

    private byte elseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @else
    {
        get
        {
            return this.elseField;
        }
        set
        {
            this.elseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockValue
{

    private xmlBlockStatementBlockNextBlockNextBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockValueBlock
{

    private xmlBlockStatementBlockNextBlockNextBlockValueBlockField fieldField;

    private xmlBlockStatementBlockNextBlockNextBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockNextBlockNextBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockValueBlockValue
{

    private xmlBlockStatementBlockNextBlockNextBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockNextBlockNextBlockValueBlockValueBlockField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatement
{

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlock
{

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlockValue valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlockValue value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlockValue
{

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueShadow shadowField;

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueShadow shadow
    {
        get
        {
            return this.shadowField;
        }
        set
        {
            this.shadowField = value;
        }
    }

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueShadow
{

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueShadowField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueShadowField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueShadowField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlock
{

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockMutation mutationField;

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValue[] valueField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockMutation mutation
    {
        get
        {
            return this.mutationField;
        }
        set
        {
            this.mutationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockMutation
{

    private byte itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValue
{

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValueBlock blockField;

    private string nameField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValueBlock block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValueBlock
{

    private xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValueBlockField fieldField;

    private string typeField;

    private string idField;

    /// <remarks/>
    public xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValueBlockField field
    {
        get
        {
            return this.fieldField;
        }
        set
        {
            this.fieldField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
public partial class xmlBlockStatementBlockNextBlockNextBlockStatementBlockValueBlockValueBlockField
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

