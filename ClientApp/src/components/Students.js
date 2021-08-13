import React from 'react';

export const Students = () => {
    return (
        <div className="mt-5">
            <h3 className="text-secondary">Студенты</h3>
            import React, { useState, useEffect} from "react";

export const Stud = () => {
  const [data, setData] = useState([]);
  const [query, setQuery] = useState("");

  useEffect(() => {
                fetch("https://jsonplaceholder.typicode.com/users")
                    .then((res) => res.json())
                    .then((json) => setData(json));
  }, []);

  const columns = data[0] && Object.keys(data[0]);

  return (
            <div>
                <div>Фильтр</div>
                <input
                    type="text"
                    value={query}
                    onChange={(e) => setQuery(e.target.value)}
                />
                {/**/}
                <div>База данных</div>
                <table cellPadding={0} cellSpacing={0}>
                    <thead>
                        <tr>{data[0] && columns.map((heading) => <th>{heading}</th>)}</tr>
                    </thead>
                    <tbody>
                        {data.map((row) => (
                            <tr>
                                <td>{row.id}</td>
                                <td>{row.name}</td>
                                <td>{row.username}</td>
                                <td>{row.email}</td>
                                <td>{row.address.city}</td>
                                <td>{row.phone}</td>
                                <td>{row.website}</td>
                                <td>{row.company.name}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
  );
};

        </div>        
    );
}