import React, { useState } from "react";
import {
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  Grid,
  TextField,
  Typography,
} from "@material-ui/core";
import ArrowBackIcon from "@material-ui/icons/ArrowBack";
import styles from "../../Theme/Styles";

const DialogComponent = ({ dialog, user, closeDialog }) => {
  const classes = styles();
  const [edit, setEdit] = useState(false);

  const handleEdit = () => {
    setEdit(!edit);
  };

  const closeDialogVer = () => {
    setEdit(false);
    closeDialog();
  };

  return (
    <Dialog open={dialog} maxWidth="xs" aling="center" fullWidth>
      <DialogTitle>
        <Typography variant="body1" color="primary">
          <span onClick={closeDialogVer}>
            <ArrowBackIcon />
          </span>
        </Typography>
        <Typography color="primary">Ver Detalles Usuario</Typography>
      </DialogTitle>
      <DialogContent>
        <form onSubmit={(e) => e.preventDefault()}>
          <Grid item xs={12} className={classes.inputForm}>
            <TextField
              label="Identificacion"
              variant="outlined"
              fullWidth
              name="id"
              disabled={!edit}
              defaultValue={user.id}
            />
          </Grid>
          <Grid item xs={12} className={classes.inputForm}>
            <TextField
              label="Nombre"
              variant="outlined"
              fullWidth
              name="name"
              disabled={!edit}
              defaultValue={user.name}
            />
          </Grid>
          <Grid item xs={12} className={classes.inputForm}>
            <TextField
              label="Edad"
              variant="outlined"
              fullWidth
              name="age"
              disabled={!edit}
              defaultValue={user.age}
            />
          </Grid>
          <Grid item xs={12} className={classes.inputForm}>
            <TextField
              label="Edad"
              variant="outlined"
              fullWidth
              name="birthday"
              type="date"
              disabled={!edit}
              defaultValue={user.birthDay}
              onChange={(e) => console.log("date", e.target.value)}
            />
          </Grid>
          <Grid item xs={12} className={classes.inputForm}>
            {!edit ? (
              <Button variant="contained" color="primary" onClick={handleEdit}>
                {"Editar"}
              </Button>
            ) : (
              <Button variant="contained" color="primary" onClick={handleEdit}>
                {"cancelar"}
              </Button>
            )}
          </Grid>
        </form>
      </DialogContent>
    </Dialog>
  );
};

export default DialogComponent;

/*
          <MuiPickersUtilsProvider utils={DateFnsUtils}>
          <Grid item xs={12}>
            <KeyboardDatePicker
              value={new Date()}
            />
          </Grid>
          </MuiPickersUtilsProvider>*/
