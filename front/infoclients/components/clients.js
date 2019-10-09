import React, { useState, useEffect } from "react";
import { Table } from "antd";

const columns = [
  {
    title: "NIT",
    dataIndex: "Nit",
    key: "Nit"
  },
  {
    title: "Full Name",
    dataIndex: "FullName",
    key: "FullName"
  },
  {
    title: "Address",
    dataIndex: "Address",
    key: "Address"
  },
  {
    title: "Phone",
    dataIndex: "Phone",
    key: "Phone"
  },
  {
    title: "Credit Limit",
    dataIndex: "CreditLimit",
    key: "CreditLimit"
  },
  {
    title: "Available Credit",
    dataIndex: "VisitsPercentage",
    key: "VisitsPercentage"
  }
];

const Clients = () => {

    const [clients,setClients] = useState([]);

    useEffect(() => {
        fetch()
    });

  return <Table columns={columns}  dataSource={clients}/>;
};

export default Clients;
