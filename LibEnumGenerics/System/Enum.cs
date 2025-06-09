/*
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
列挙型をジェネリックと併用する際の処理を保持するクラス

Enum.cs
────────────────────────────────────────
2025 Wataame
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
*/
using System.Runtime.CompilerServices;
#pragma warning disable IDE0130

namespace System
{
    /// <summary>
    /// 列挙型をジェネリックと併用する際の処理を保持するクラス
    /// </summary>
    /// <typeparam name="T">列挙型</typeparam>
    public class Enum<T> where T : unmanaged, Enum
    {
        /// <summary>
        /// 列挙型のサイズ
        /// </summary>
        private static readonly int enumSize;


        /// <summary>
        /// 初期化処理
        /// </summary>
        static Enum()
        {
            unsafe
            {
                // 列挙型のサイズを取得する
                enumSize = sizeof(T);
            }
        }

        /// <summary>
        /// 8ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(byte value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合
                        byte* p1 = (byte*)pResult;
                        *p1 = value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合
                        ushort* p2 = (ushort*)pResult;
                        *p2 = value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        uint* p4 = (uint*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        ulong* p8 = (ulong*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 8ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(sbyte value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合
                        sbyte* p1 = (sbyte*)pResult;
                        *p1 = value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合
                        short* p2 = (short*)pResult;
                        *p2 = value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        int* p4 = (int*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        long* p8 = (long*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 16ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(ushort value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上1バイトを破棄する)
                        byte* p1 = (byte*)pResult;
                        *p1 = (byte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合
                        ushort* p2 = (ushort*)pResult;
                        *p2 = value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        uint* p4 = (uint*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        ulong* p8 = (ulong*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 16ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(short value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上1バイトを破棄する)
                        sbyte* p1 = (sbyte*)pResult;
                        *p1 = (sbyte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合
                        short* p2 = (short*)pResult;
                        *p2 = value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        int* p4 = (int*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        long* p8 = (long*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 32ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(uint value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上3バイトを破棄する)
                        byte* p1 = (byte*)pResult;
                        *p1 = (byte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合(上2バイトを破棄する)
                        ushort* p2 = (ushort*)pResult;
                        *p2 = (ushort)value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        uint* p4 = (uint*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        ulong* p8 = (ulong*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 32ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(int value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上3バイトを破棄する)
                        sbyte* p1 = (sbyte*)pResult;
                        *p1 = (sbyte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合(上2バイトを破棄する)
                        short* p2 = (short*)pResult;
                        *p2 = (short)value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        int* p4 = (int*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        long* p8 = (long*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 64ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(ulong value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上7バイトを破棄する)
                        byte* p1 = (byte*)pResult;
                        *p1 = (byte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合(上6バイトを破棄する)
                        ushort* p2 = (ushort*)pResult;
                        *p2 = (ushort)value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合(上4バイトを破棄する)
                        uint* p4 = (uint*)pResult;
                        *p4 = (uint)value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        ulong* p8 = (ulong*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 64ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(long value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上7バイトを破棄する)
                        sbyte* p1 = (sbyte*)pResult;
                        *p1 = (sbyte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合(上6バイトを破棄する)
                        short* p2 = (short*)pResult;
                        *p2 = (short)value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合(上4バイトを破棄する)
                        int* p4 = (int*)pResult;
                        *p4 = (int)value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        long* p8 = (long*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }
    }
}
