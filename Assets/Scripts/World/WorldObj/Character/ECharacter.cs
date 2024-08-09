using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimWorld
{
    /// <summary>
    /// 角色性别
    /// </summary>
    public enum ECharacter_Gender : byte
    {
        None,
        Male,
        Female
    }

    /// <summary>
    /// 角色能进行的工作类别
    /// </summary>
    [Flags]
    public enum ECharacter_WorkTags
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,
        /// <summary>
        /// 灭火
        /// </summary>
        Firefighting = 2,
        /// <summary>
        /// 就医
        /// </summary>
        hospitalize = 4,
        /// <summary>
        /// 医生
        /// </summary>
        Commoner = 8,
        /// <summary>
        /// 保育
        /// </summary>
        Nursing = 0x10,
        /// <summary>
        /// 基本
        /// </summary>
        Basic = 0x20,
        /// <summary>
        /// 监管
        /// </summary>
        Supervise = 0x40,
        /// <summary>
        /// 驯兽
        /// </summary>
        Animals  = 0x80,
        /// <summary>
        /// 烹饪
        /// </summary>
        Cooking = 0x100,
        /// <summary>
        /// 狩猎 
        /// </summary>
        Hunting = 0x200,
        /// <summary>
        /// 建造 
        /// </summary>
        Constructing  = 0x400,
        /// <summary>
        /// 种植
        /// </summary>
        PlantWork = 0x800,
        /// <summary>
        /// 采矿
        /// </summary>
        Mining = 0x1000,
        /// <summary>
        /// 割除 
        /// </summary>
        Resect  = 0x2000,
        /// <summary>
        /// 锻造 
        /// </summary>
        Crafting  = 0x4000,
        /// <summary>
        /// 缝制
        /// </summary>
        Tailor = 0x8000,
        /// <summary>
        /// 艺术
        /// </summary>
        Artistic = 0x10000,
        /// <summary>
        /// 制作
        /// </summary>
        Manufacture = 0x20000,
        /// <summary>
        /// 清洁
        /// </summary>
        Cleaning = 0x40000,
        /// <summary>
        /// 搬运
        /// </summary>
        Hauling = 0x80000,
        /// <summary>
        ///  清洁
        /// </summary>
        Clean =0x100000,
        /// <summary>
        /// 研究
        /// </summary>
        Intellectual = 0x200000,
        /// <summary>
        /// 全部工作
        /// </summary>
        AllWork = 0x400000,
    }
}

