using System;
using System.Collections.Generic;
using System.Text;

namespace TesseractNet
{
    public class Classify
    {
        public static int MAX_NUM_CLASSES = 8192;
        public static int MAX_NUM_CONFIGS = 64;
        public static ADAPT_TEMPLATES AdaptedTemplates;
        public static void EndAdaptiveClassifier()
        {
            string filename = "";
            if (Classify.AdaptedTemplates != null)
            {

            }
        }

        public static void free_adapted_templates(ADAPT_TEMPLATES templates)
        {
            if (templates != null)
            {
                for (int i = 0; i < templates.Templates.NumClasses; i++)
                {
                    free_adapted_class(templates.Class[i]);
                    free_int_templates(templates->Templates);
                    Efree(templates);
                }                
            }
        }

        public static void free_adapted_class(ADAPT_CLASS adapt_class)
        {
            for (int i = 0; i < MAX_NUM_CONFIGS; i++)
            {

            }

            
        }
    }

    public struct ADAPT_TEMPLATES : IComparable, IEquatable<ADAPT_TEMPLATES>
    {
        public INT_TEMPLATES Templates;
        public int NumNonEmptyClasses;
        public byte NumPermClasses;
        public byte[] dummy;
        public ADAPT_CLASS[] Class; //ADAPT_CLASS Class[MAX_NUM_CLASSES]; 8192


        public static bool operator !=(ADAPT_TEMPLATES a, ADAPT_TEMPLATES b)
        {
            return false;
        }

        public static bool operator ==(ADAPT_TEMPLATES a, ADAPT_TEMPLATES b)
        {
            return false;
        }
    }

    public struct ADAPT_CLASS
    {
        byte NumPermConfigs;
        byte MaxNumTimesSeen;  // maximum number of times any TEMP_CONFIG was seen
        byte[] dummy;         // (cut at matcher_min_examples_for_prototyping)
        UInt32 PermProtos;
        UInt32 PermConfigs;
        LIST TempProtos;
        ADAPTED_CONFIG[] Config; //ADAPTED_CONFIG Config[MAX_NUM_CONFIGS];//MAX_NUM_CONFIGS   64
    }

    public struct list_rec
    {
        //list_rec node;
        //list_rec next;
    }

    public struct LIST
    {
        list_rec node;
        list_rec next;
    }

    public struct ADAPTED_CONFIG
    {
        TEMP_CONFIG Temp;
        PERM_CONFIG Perm;
    }

    public struct TEMP_CONFIG
    {
        byte NumTimesSeen;
        byte ProtoVectorSize;
        PROTO_ID MaxProtoId;
        LIST ContextsSeen;
        BIT_VECTOR Protos;
        int FontinfoId;  // font information inferred from pre-trained templates
    }

    public struct PERM_CONFIG
    {
        UNICHAR_ID Ambigs;
        int FontinfoId;  // font information inferred from pre-trained templates
    }

    public struct INT_TEMPLATES
    {
        public int NumClasses;
        public int NumClassPruners;
        public INT_CLASS[] Class;
        public CLASS_PRUNER[] ClassPruner;
    }

    public struct INT_CLASS
    {

        UInt16 NumProtos;
        byte NumProtoSets;
        uinT8 NumConfigs;
        PROTO_SET[] ProtoSets;
        uinT8 ProtoLengths;
        uinT16[] ConfigLengths;
        int font_set_id;  // FontSet id, see above
    }


    public struct PROTO_SET
    {
        PROTO_PRUNER ProtoPruner;
        INT_PROTO_STRUCT[] Protos;
    }

    public struct INT_PROTO_STRUCT
    {
        inT8 A;
        uinT8 B;
        inT8 C;
        uinT8 Angle;
        uinT32[] Configs;
    }

    public struct INT_PROTO
    {
        inT8 A;
        uinT8 B;
        inT8 C;
        uinT8 Angle;
        uinT32[] Configs;
    }

    public struct inT8
    {
        char value;
    }

    public struct uinT8
    {
        byte value;
    }

    public struct uinT16
    {
        UInt16 value;
    }

    public struct uinT32
    {
        UInt32 value;
    }

    public struct PROTO_ID
    {
        Int16 value;
    }

    public struct PROTO_PRUNER
    {
        UInt32[, ,] value;
    }

    public struct CLASS_PRUNER
    {
        UInt32[, ,] value;
    }

    public struct BIT_VECTOR
    {
        UInt32 value;
    }

    public struct UNICHAR_ID
    {
        int value;
    }
}
