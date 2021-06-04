import React from "react";
import {
  Paper,
  TableBody,
  Table as TableMaterial,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Button,
} from "@material-ui/core";
import styles from "../../Theme/Styles";

const Table = ({ openDialog, setUser, users }) => {
  const classes = styles();

  const onShowButton = (user) => {
    setUser({
      id: user.id,
      name: user.name,
      age: user.age,
      birthDay: user.birthDay,
    });
    openDialog();
  };
  return (
    <TableContainer component={Paper} className={classes.table}>
      <TableMaterial>
        <TableHead>
          <TableRow>
            <TableCell width="20%">Id</TableCell>
            <TableCell width="20%">Name</TableCell>
            <TableCell width="20%">Age</TableCell>
            <TableCell width="20%">BirthDay</TableCell>
            <TableCell align="center" width="20%"></TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {users.map((us) => (
            <TableRow key={us.id}>
              <TableCell>{us.id}</TableCell>
              <TableCell>{us.name}</TableCell>
              <TableCell>{us.age}</TableCell>
              <TableCell>
                {new Intl.DateTimeFormat('en-GB',{
                  day: "2-digit",
                  month: "long",
                  year: "numeric",
                }).format(new Date(`${us.birthDay}T00:00:00`))}
              </TableCell>
              <TableCell>
                <Button
                  variant="contained"
                  color="primary"
                  onClick={() => {
                    onShowButton(us);
                  }}
                >
                  {"Ver"}
                </Button>
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </TableMaterial>
    </TableContainer>
  );
};

export default Table;
