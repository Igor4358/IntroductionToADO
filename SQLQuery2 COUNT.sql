USE PD_318_DML;

SELECT
      group_id AS 'ID',
      group_name AS N'Название группы',
      direction_name AS N'Направление обучения',
      COUNT (student_id)

      FROM Students,Groups,Directions
      WHERE direction = direction_id
      AND [group] = group_id
      GROUP BY group_id,group_name,direction_name;