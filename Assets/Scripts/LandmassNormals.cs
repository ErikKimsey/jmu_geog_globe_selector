using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LandmassNormals : MonoBehaviour
{
    [SerializeField] private GameObject m_Indicator;
    [SerializeField] private MeshFilter m_Mesh;
    private Vector3[] m_Normals;

    private void Awake()
    {
        m_Normals = m_Mesh.mesh.normals;
    }

    public void CreatePrimitives(List<ActivityItem> _itemList)
    {
        if (m_Normals != null)
        {
            for (int i = 0; i < _itemList.Count; i++)
            {
                int tempI = Random.Range(0, m_Normals.Length);
                Vector3 mPos = new Vector3(m_Normals[tempI].x, m_Normals[tempI].y, m_Normals[tempI].z);
                Quaternion mRot = Quaternion.FromToRotation(Vector3.up, mPos.normalized);
                GameObject indc8tr = Instantiate(m_Indicator, mPos,
                    mRot, transform);
            }
        }
        else
        {
            Debug.Log("NO NORMALS IN CREATE PRIMI");
        }
    }
}